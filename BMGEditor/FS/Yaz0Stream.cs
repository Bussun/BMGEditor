using System;
using System.IO;

namespace BMGEditor
{
    public class Yaz0Stream : MemoryStream 
    {
        public Yaz0Stream(Stream backend)
            : base(1)
        {
            if (backend is Yaz0Stream) throw new Exception("sorry but no");

            m_Backend = backend;

            m_Backend.Position = 0;
            byte[] buffer = new byte[m_Backend.Length];
            m_Backend.Read(buffer, 0, (int)m_Backend.Length);

            Yaz0.Decompress(ref buffer);
            Position = 0;
            Write(buffer, 0, buffer.Length);
        }


        private Stream m_Backend;
    }

    public static class Yaz0 // TODO: Finish rewriting this
    {
        public static void Decompress(ref byte[] data)
        {
            if (data[0] != 'Y' || data[1] != 'a' || data[2] != 'z' || data[3] != '0')
                return;

            Int32 decompSize = (data[4] << 24 | data[5] << 16 | data[6] << 8 | data[7]);
            uint sourcePos = 16; //start at 0x10
            uint writePos = 0; //destination to write data to
            byte[] decodedData = new byte[decompSize + 1];
            byte groupHead = 0;
            byte lastGroupHead = 0;
            uint validBitCount = 0;

            while (writePos < decompSize)
            {
                //System.Windows.Forms.MessageBox.Show(groupHead.ToString("X") + "|" + validBitCount);
                if (validBitCount == 0) //new group header 
                {
                    groupHead = data[sourcePos];
                    lastGroupHead = groupHead;
                    ++sourcePos;
                    validBitCount = 8; //reset count
                }
                if ((groupHead & 0x80) != 0) //straight copy as long as groupheader maintains left most bit as 1 (1000 0000)
                {
                    decodedData[writePos] = data[sourcePos];
                    writePos++;
                    sourcePos++;
                }
                else
                {
                    byte b1 = data[sourcePos]; //byte 1 
                    byte b2 = data[sourcePos + 1]; //byte 2
                    sourcePos += 2; //move past those two bytes
                    uint dist = (uint)((b1 & 0xF) << 8) | b2; //distance
                    if (Tests.isBE)
                        dist = (UInt32)((dist >> 24) | ((dist & 0xFF0000) >> 8) | ((dist & 0xFF00) << 8) | (dist << 24));

                    uint copySource = writePos - (dist + 1); //copy 
                    uint numBytes = (uint)b1 >> 4; //how many bytes to copy

                    //if (sourcePos-2 > 0x13C0) //debug decode
                    //System.Windows.Forms.MessageBox.Show("lastGroupHead: 0x" + lastGroupHead.ToString("X") + "\n" + "b1: 0x" + b1.ToString("X") + "\n" + "b2: 0x" + b2.ToString("X") + "\n" + "sourcePos: 0x" + sourcePos.ToString("X") + "\n" + "dist: " + dist + "\n" + "copySource: 0x" + copySource.ToString("X") + "\n" + "writePos: 0x" + writePos.ToString("X") + "\n" + "numBytes: " + numBytes);

                    if (numBytes == 0) //If the first 4 bits of the first byte is 0...
                    {
                        numBytes = data[sourcePos] + (uint)0x12;
                        sourcePos++;
                    }
                    else
                    {
                        numBytes += 2;
                    }
                    for (int i = 0; i < numBytes; ++i)
                    {
                        decodedData[writePos] = decodedData[copySource];
                        copySource++;
                        writePos++;
                    }
                }
                groupHead <<= 1; //left shift!!!
                validBitCount -= 1; //group header validation count of the binary position
            }

            Array.Resize(ref data, decompSize + 1);
            decodedData.CopyTo(data, 0);
            FileStream test = File.OpenWrite("./test.bin");
            test.Write(data);
            return;
        }
    }
}
