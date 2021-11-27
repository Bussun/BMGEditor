using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMGEditor
{
    public class BMG
    {
        private FileBase m_File;
        private const Int32 m_Signature = 0x4D455347;
        private const Int32 m_FileType = 0x626D6731;
        private const Byte m_ExpectedEncoding = 0x02;

        private const Int32 INF1magic = 0x494E4631;
        private const Int32 DAT1magic = 0x44415431;
        private const Int32 FLW1magic = 0x464C5731;
        private const Int32 FLI1magic = 0x464C4931;

        public BMG(FileBase file, Bcsv tbl)
        {
            m_File = file;
            m_File.BigEndian = true;
            m_File.Encoding = Encoding.BigEndianUnicode;
            m_File.Stream.Position = 0;

            Int32 headermagic1 = m_File.Reader.ReadInt32();
            Int32 headermagic2 = m_File.Reader.ReadInt32();
            if (headermagic1 == m_Signature && headermagic2 == m_FileType) { Console.WriteLine("Nice"); } else { Console.WriteLine("not nice");}

            UInt32 fileSize = m_File.Reader.ReadUInt32();
            UInt32 numberOfSections = m_File.Reader.ReadUInt32();
            Byte fileEncoding = m_File.Reader.ReadByte();
            if (fileEncoding != m_ExpectedEncoding) throw new Exception("sorry but no");
            m_File.Stream.Position = 0x20;

            //INF1
            Int32 INF1sectionMagic = m_File.Reader.ReadInt32();
            if (INF1sectionMagic != INF1magic)
            {
                throw new Exception("BMG File exists but isn't in the expected format");
            }
            UInt32 INF1sectionSize = m_File.Reader.ReadUInt32();
            UInt16 INF1itemNumber = m_File.Reader.ReadUInt16();
            UInt16 INF1itemLength = m_File.Reader.ReadUInt16();
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
            m_File.Stream.Position += 0x10;

            //DAT1
            long DAT1sectionStart = m_File.Stream.Position;
            Int32 DAT1sectionMagic = m_File.Reader.ReadInt32();
            UInt32 DAT1sectionSize = m_File.Reader.ReadUInt32();
            long strPoolStart = m_File.Stream.Position;
            if (DAT1sectionMagic != DAT1magic) throw new Exception("BMG exists but isn\'t in the expected format");
            for (int j = 0; j < INF1itemNumber; j++)
            {
                m_File.Stream.Position = strPoolStart + Entries[j].offset;
                Entries[j].text = ReadWideCharString();
            }

            int l = 0;
            foreach (Bcsv.Entry bcsvEntry in tbl.Entries)
            {
                string entName = bcsvEntry[563954530].ToString();
                Entries[l].entryName = entName;
                l++;
            }

            //FLW1
            m_File.Stream.Position = DAT1sectionStart + DAT1sectionSize;
            long FLW1sectionStart = m_File.Stream.Position;
            Int32 FLW1sectionMagic = m_File.Reader.ReadInt32();
            if (FLW1sectionMagic != FLW1magic) throw new Exception("FLW1 section missing. Check your BMG file");
            UInt32 FLW1sectionSize = m_File.Reader.ReadUInt32();


            //FLI1
            m_File.Stream.Position = FLW1sectionStart + FLW1sectionSize;
            long FLI1sectionStart = m_File.Stream.Position;
            Int32 FLI1sectionMagic = m_File.Reader.ReadInt32();
            if (FLI1sectionMagic != FLI1magic) throw new Exception("FLI1 section missing. Check your BMG file");
            UInt32 FLI1sectionSize = m_File.Reader.ReadUInt32();
        }

        public void Close()
        {
            m_File.Close();
        }

        public class TextEntry
        {
            public int entryNo;
            public string text;
            public UInt32 offset;
            public string entryName;

            //Properties
            public byte unk1;
            public byte cameraOpt;
            public byte sndEffectOpt;
            public byte unk2;
            public byte messageTriggerOpt;
            public byte messageLayoutOpt;
            public byte messageAreaOpt;
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
                    ret += "\"" + c;
                    escSeqLength = m_File.Reader.ReadByte();
                    ret += $" {escSeqLength} ";
                    for (int k = 3; k < escSeqLength; k++)
                    {
                        ret += m_File.Reader.ReadByte() + " ";
                    }
                    ret += "\"";
                }
                else
                    ret += c;
            }
            return ret;


        }

        public List<TextEntry> Entries;
    }
}
