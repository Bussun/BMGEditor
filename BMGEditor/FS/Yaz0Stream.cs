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

    public static class Yaz0 // TODO: Write it
    {
        unsafe public static void Decompress(ref byte[] data)
        {
            if (data[0] != 'Y' || data[1] != 'a' || data[2] != 'z' || data[3] != '0')
                return;

            Int32 decompSize = (data[4] << 24 | data[5] << 16 | data[6] << 8 | data[7]);
            Byte[] output = new Byte[decompSize + 1];

            /* Tryed rewriting it using szs tools code from MKW Wiki, not a real success
            uint pos = 0x10;
            uint outPos = 0x00;

            byte group_head = 0;
            int group_head_length = 0;

            while (pos < data.Length && outPos < output.Length)
            {
                if (group_head_length == 0)
                {
                    group_head = data[pos];
                    pos++;
                    group_head_length = 8;
                }
                group_head_length--;
                if ((group_head & 0x80) != 0)
                {
                    output[outPos] = data[pos];
                    outPos++; pos++;
                }
                else
                {
                    byte b1 = data[pos]; pos++;
                    byte b2 = data[pos]; pos++;

                    uint copy_src = (uint)(outPos - ((b1 & 0x0F) << 8 | b2) - 1);
                    int n = b1 >> 4;

                    if (n == 0)
                    {
                        n = data[pos] + 0x12; pos++;
                    }
                    else
                    {
                        n += 2;
                    }

                    while (n-- < 0)
                    {
                        output[outPos] = output[copy_src];
                    }
                }
                group_head <<= 1;
            }
            */

            int Read_Position = 0x10;
            int Write_Position = 0;
            uint ValidBitCount = 0;
            byte CurrentCodeByte = 0;

            while (Write_Position < decompSize)
            {
                if (ValidBitCount == 0)
                {
                    CurrentCodeByte = data[Read_Position];
                    ++Read_Position;
                    ValidBitCount = 8;
                }

                if ((CurrentCodeByte & 0x80) != 0)
                {
                    output[Write_Position] = data[Read_Position];
                    Write_Position++;
                    Read_Position++;
                }
                else
                {
                    byte Byte1 = data[Read_Position];
                    byte Byte2 = data[Read_Position + 1];
                    Read_Position += 2;

                    //uint Dist = (uint)(((Byte1 & 0xF) << 8) | Byte2);
                    uint Dist = (uint)(Byte2 | ((Byte1 & 0xF) << 8));
                    uint CopySource = (uint)(Write_Position - Dist - 1);

                    uint Byte_Count = (uint)(Byte1 >> 4);
                    if (Byte_Count == 0)
                    {
                        Byte_Count = (uint)(data[Read_Position] + 0x12);
                        Read_Position++;
                    }
                    else
                    {
                        Byte_Count += 2;
                    }

                    for (int i = 0; i < Byte_Count; ++i)
                    {
                        output[Write_Position] = output[CopySource];
                        CopySource++;
                        Write_Position++;
                    }
                }

                CurrentCodeByte <<= 1;
                ValidBitCount -= 1;
            }

            Array.Resize(ref data, decompSize + 1);
            output.CopyTo(data, 0);

            FileStream test = File.OpenWrite("./test.bin");
            test.Write(output);
            test.Flush();
            test.Close();
            return;
        }
    }
}
