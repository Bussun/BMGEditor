using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BMGEditor
{
    public class BMG
    {
        private FileBase m_File;
        private Bcsv m_File_Tbl;
        private const Int32 m_Signature = 0x4D455347;
        private const Int32 m_FileType = 0x626D6731;
        private const Byte m_ExpectedEncoding = 0x02;

        private const Int32 INF1magic = 0x494E4631;
        private const Int32 DAT1magic = 0x44415431;
        private const Int32 FLW1magic = 0x464C5731;
        private const Int32 FLI1magic = 0x464C4931;

        //Header
        private Int32 fileMagic1;
        private Int32 fileMagic2;
        private UInt32 fileSize;
        private UInt32 numberOfSections;
        private Byte fileEncoding;
        
        //INF1
        private Int32 INF1sectionMagic;
        private UInt32 INF1sectionSize;
        private UInt16 INF1itemNumber;
        private UInt16 INF1itemLength;

        //DAT1
        private Int64 DAT1sectionStart;
        private Int32 DAT1sectionMagic;
        private UInt32 DAT1sectionSize;
        private Int64 strPoolStart;

        //FLW1 
        private Int64 FLW1sectionStart;
        private Int32 FLW1sectionMagic;
        private UInt32 FLW1sectionSize;
        private List<Byte> FLW1sectionContent = new List<byte>();

        //FLI1
        private Int64 FLI1sectionStart;
        private Int32 FLI1sectionMagic;
        private UInt32 FLI1sectionSize;
        private List<Byte> FLI1sectionContent = new List<byte>();

        public BMG(FileBase file, Bcsv tbl)
        {
            m_File_Tbl = tbl;
            m_File = file;
            m_File.BigEndian = true;
            m_File.Encoding = Encoding.BigEndianUnicode;
            m_File.Stream.Position = 0;

            fileMagic1 = m_File.Reader.ReadInt32();
            fileMagic2 = m_File.Reader.ReadInt32();
            if (fileMagic1 == m_Signature && fileMagic2 == m_FileType) { }
            else
                throw new Exception("Not a valid BMG file.");

            fileSize = m_File.Reader.ReadUInt32();
            numberOfSections = m_File.Reader.ReadUInt32();
            fileEncoding = m_File.Reader.ReadByte();
            if (fileEncoding != m_ExpectedEncoding) throw new Exception("sorry but no");
            m_File.Stream.Position = 0x20;

            //INF1
            INF1sectionMagic = m_File.Reader.ReadInt32();
            if (INF1sectionMagic != INF1magic)
            {
                throw new Exception("BMG File exists but isn't in the expected format");
            }
            INF1sectionSize = m_File.Reader.ReadUInt32();
            INF1itemNumber = m_File.Reader.ReadUInt16();
            INF1itemLength = m_File.Reader.ReadUInt16();
            m_File.Stream.Position += 0x04;

            Entries = new List<TextEntry>();
            for (int i = 0; i < INF1itemNumber; i++)
            {
                TextEntry txtEntry = new TextEntry();
                txtEntry.entryNo = i;
                txtEntry.offset = m_File.Reader.ReadUInt32();
                txtEntry.unk1 = m_File.Reader.ReadByte();
                txtEntry.cameraOpt = m_File.Reader.ReadByte();
                txtEntry.sndEffectOpt = m_File.Reader.ReadByte();
                txtEntry.unk2 = m_File.Reader.ReadByte();
                txtEntry.messageTriggerOpt = m_File.Reader.ReadByte();
                txtEntry.messageLayoutOpt = m_File.Reader.ReadByte();
                txtEntry.messageAreaOpt = m_File.Reader.ReadByte();

                Entries.Add(txtEntry);
                m_File.Stream.Position += 0x01;
            }

            while (m_File.Reader.ReadByte() != 0x44)
                m_File.Stream.Position += 0x01;
            m_File.Stream.Position -= 1;

            //DAT1
            DAT1sectionStart = m_File.Stream.Position;
            DAT1sectionMagic = m_File.Reader.ReadInt32();
            DAT1sectionSize = m_File.Reader.ReadUInt32();

            strPoolStart = m_File.Stream.Position;
            if (DAT1sectionMagic != DAT1magic) throw new Exception("BMG exists but isn\'t in the expected format");
            for (int j = 0; j < INF1itemNumber; j++)
            {
                m_File.Stream.Position = strPoolStart + Entries[j].offset;
                Entries[j].text = ReadWideCharString();
            }

            m_File_Tbl.Entries.Sort((x, y) =>
            {
                UInt32 a = (UInt32)x[70793394], b = (UInt32)y[70793394];
                return a.CompareTo(b);
            });
            int l = 0;
            foreach (Bcsv.Entry bcsvEntry in m_File_Tbl.Entries)
            {
                string entName = bcsvEntry[563954530].ToString();
                Entries[l].entryName = entName;
                l++;
            }

            //FLW1
            m_File.Stream.Position = DAT1sectionStart + DAT1sectionSize;
            FLW1sectionStart = m_File.Stream.Position;
            FLW1sectionMagic = m_File.Reader.ReadInt32();
            if (FLW1sectionMagic != FLW1magic) throw new Exception("FLW1 section missing. Check your BMG file");
            FLW1sectionSize = m_File.Reader.ReadUInt32();
            for (int i = 0; i < FLW1sectionSize - 0x08; i++)
            {
                FLW1sectionContent.Add(m_File.Reader.ReadByte());
            }


            //FLI1
            m_File.Stream.Position = FLW1sectionStart + FLW1sectionSize;
            FLI1sectionStart = m_File.Stream.Position;
            FLI1sectionMagic = m_File.Reader.ReadInt32();
            if (FLI1sectionMagic != FLI1magic) throw new Exception("FLI1 section missing. Check your BMG file");
            FLI1sectionSize = m_File.Reader.ReadUInt32();
            for (int i = 0; i < FLI1sectionSize - 0x08; i++)
            {
                FLI1sectionContent.Add(m_File.Reader.ReadByte());
                /*For some reason Nintendo decided to set this section's size 0x10 bytes more than 
                 *it really is (aligned size vs real size), so checking if we are at the end of the
                 *stream to avoid a EndOfStreamException and changing the section size if incorrect
                 *since the game (thanks god) doesn't care about that */
                if (m_File.Stream.Length - m_File.Stream.Position == 0) 
                {
                    FLI1sectionSize = (UInt32)(m_File.Stream.Position - FLI1sectionStart);
                    break;
                }
            }
        }

        public void Close()
        {
            m_File.Close();
        }

        public class TextEntry
        {
            public int entryNo;
            public string text = "";
            public UInt32 offset;
            public string entryName = "";

            //Properties
            public byte unk1;
            public byte cameraOpt;
            public byte sndEffectOpt;
            public byte unk2;
            public byte messageTriggerOpt;
            public byte messageLayoutOpt;
            public byte messageAreaOpt;
        }

        public class EscapeSequence
        {
            public byte length;
            public byte unk1;
            public List<Byte> binValue = new List<Byte>();
        }

        public List<Byte> BytesFromEscapeSequence(EscapeSequence escSeq)
        {
            List<Byte> ret = new List<byte>();
            ret.Add(0x00);
            ret.Add(0x1A);
            ret.Add(escSeq.length);
            ret.Add(escSeq.unk1);

            foreach (Byte b in escSeq.binValue)
            {
                ret.Add(b);
            }
            return ret;
        }

        public string ReadWideCharString()
        {
            byte escSeqLength;

            string ret = "";
            char c;
            while ((c = m_File.Reader.ReadChar()) != '\0')
            {
                if (c == 0x001A)
                {
                    ret += "*" ;
                    escSeqLength = m_File.Reader.ReadByte();
                    ret += $"{String.Format("{0:X2}", escSeqLength)}";
                    for (int k = 3; k < escSeqLength; k++)
                    {
                        ret += String.Format("{0:X2}", m_File.Reader.ReadByte());
                    }
                    ret += " ";
                }
                else
                    ret += c;
            }
            return ret;


        }

        public void AddNewEntry(string newEntryName)
        {
            TextEntry newEntry = new TextEntry();
            newEntry.entryName = newEntryName;
            newEntry.entryNo = INF1itemNumber;
            newEntry.text = "";
            newEntry.unk1 = 0x00; newEntry.cameraOpt = 0x00; newEntry.sndEffectOpt = 0x00;
            newEntry.unk2 = 0x00; newEntry.messageTriggerOpt = 0x00; newEntry.messageLayoutOpt = 0x00;
            newEntry.messageAreaOpt = 0xFF;
            INF1itemNumber++;
            Entries.Add(newEntry);

           /* Entries.Sort((x, y) =>
            {
                string entryNameA = x.entryName, entryNameB = y.entryName;
                return String.CompareOrdinal(entryNameA, entryNameB);
            });

            for (int i = 0; i < INF1itemNumber; i++)
            {
                Entries[i].entryNo = i;
            }*/
        }

        [Obsolete]
        public void DeleteEntry(Int32 entryIndex) //Problem: if custom entries, alphabetical index != in-game/tbl index
        {
            Entries.Remove(Entries[entryIndex]);
            INF1itemNumber--;
        }

        public void WriteToFile()
        {
            //File header
            m_File.Stream.Position = 0;
            m_File.Writer.Write((Int32)m_Signature);
            m_File.Writer.Write((Int32)m_FileType);
            m_File.Writer.Write((UInt32)0x00); //Final fileSize will be written at the end
            m_File.Writer.Write((UInt32)0x04); //Number of sections, always 4 in Super Mario Galaxy, this editor isn't meant to be used on anything else anyway.
            m_File.Writer.Write((Byte)0x02); //Encoding
            while (m_File.Stream.Position != 0x20) m_File.Writer.Write((Byte)0x00); // The 15 bytes of nothing

            //INF1 section
            Int64 INF1start = m_File.Stream.Position;
            m_File.Writer.Write((Int32)INF1magic);
            m_File.Writer.Write((UInt32)(0x00)); //Section size
            m_File.Writer.Write((UInt16)INF1itemNumber);
            m_File.Writer.Write((UInt16)INF1itemLength);
            m_File.Writer.Write((UInt32)0x00);
            foreach (TextEntry entry in Entries)
            {
                m_File.Writer.Write((UInt32)0x00);
                m_File.Writer.Write((Byte)entry.unk1);
                m_File.Writer.Write((Byte)entry.cameraOpt);
                m_File.Writer.Write((Byte)entry.sndEffectOpt);
                m_File.Writer.Write((Byte)entry.unk2);
                m_File.Writer.Write((Byte)entry.messageTriggerOpt);
                m_File.Writer.Write((Byte)entry.messageLayoutOpt);
                m_File.Writer.Write((Byte)entry.messageAreaOpt);
                m_File.Writer.Write((Byte)0xFF);
            }
            while (m_File.Stream.Position % 16 != 0x00)
                m_File.Writer.Write((Byte)0x00);
            Int64 INF1end = m_File.Stream.Position;
            m_File.Stream.Position = INF1start + 0x04;
            m_File.Writer.Write((UInt32)(INF1end - INF1start));
            m_File.Stream.Position = INF1end;



            //DAT1
            Int64 DAT1start = m_File.Stream.Position;
            m_File.Writer.Write((Int32)DAT1magic);
            m_File.Writer.Write((UInt32)0x00); //section size, will be defined later
            //String pool
            List<Int64> strPos = new List<Int64>();
            foreach (TextEntry entry in Entries)
            {
                strPos.Add(m_File.Stream.Position - (DAT1start + 0x08));
                //Doing this because for some reason there's a random char appearing at the beggining of each str
                if (entry.text == "") m_File.Writer.Write((UInt16)0x00);
                else
                {
                    List<char> strToWrite = new List<char>();
                    foreach (char c in entry.text)
                    {
                        strToWrite.Add(c);
                    }

                    for (int i = 0; i < strToWrite.Count; i++)
                    {
                        if (strToWrite[i].Equals('*'))
                        {
                            EscapeSequence escSeq = new EscapeSequence();
                            escSeq.length = Byte.Parse(String.Concat(strToWrite[i + 1], strToWrite[i + 2]), NumberStyles.HexNumber);
                            escSeq.unk1 = Byte.Parse(String.Concat(strToWrite[i + 3], strToWrite[i + 4]), NumberStyles.HexNumber);
                            i += 0x05;
                            for (int j = 0; j < escSeq.length * 2 - 8; j += 2)
                            {
                                escSeq.binValue.Add(Byte.Parse(String.Concat(strToWrite[i + j], strToWrite[i + j + 1]), NumberStyles.HexNumber));
                            }

                            List<Byte> seqToWrite = BytesFromEscapeSequence(escSeq);
                            foreach (Byte b in seqToWrite)
                            {
                                m_File.Writer.Write(b);
                            }
                            i += escSeq.length * 2 - 8;


                        }
                        else
                            m_File.Writer.Write(strToWrite[i]);
                    }

                    m_File.Writer.Write((UInt16)0x00);

                }
            }

            while (m_File.Stream.Position % 16 != 0x00)
                m_File.Writer.Write((Byte)0x00);
            Int64 DAT1size = m_File.Stream.Position - DAT1start;
            Int64 DAT1end = m_File.Stream.Position;
            m_File.Stream.Position = DAT1start + 0x04;
            m_File.Writer.Write((UInt32)DAT1size);

            //Setting offsets in INF1
            m_File.Stream.Position = INF1start;
            m_File.Stream.Position += 0x10;
            for (int index = 0; index < INF1itemNumber; index++)
            {
                m_File.Writer.Write((UInt32)strPos[index]);
                m_File.Stream.Position += 0x08;
            }
            m_File.Stream.Position = DAT1end;

            m_File.Writer.Write((Int32)FLW1magic);
            m_File.Writer.Write((UInt32)FLW1sectionSize);
            foreach (byte b in FLW1sectionContent)
                m_File.Writer.Write(b);

            m_File.Writer.Write((Int32)FLI1magic);
            m_File.Writer.Write((UInt32)FLI1sectionSize);
            foreach (byte b in FLI1sectionContent)
                m_File.Writer.Write(b);

            Int64 newFileSize = m_File.Stream.Position;
            m_File.Stream.Position = 0x08;
            m_File.Writer.Write((UInt32)newFileSize);

            m_File.Stream.SetLength(newFileSize);

            m_File.Flush();
        }

        public List<TextEntry> Entries;
    }
}
