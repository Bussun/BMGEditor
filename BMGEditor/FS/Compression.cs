using System;

namespace BMGEditor
{
    public static class Yaz0 // TODO: Finish rewriting this
    {
        public static void Decompress(ref byte[] data)
        {
            if (data[0] != 'Y' || data[1] != 'a' || data[2] != 'z' || data[3] != '0')
                return;

            Int32 decompSize = (data[4] << 24 | data[5] << 16 | data[6] << 8 | data[7]);
            byte[] output = new byte[decompSize];
            int Offs = 16;
            int dstoffs = 0;
            while (true)
            {
                byte header = data[Offs++];
                for (int i = 0; i < 8; i++)
                {
                    if ((header & 0x80) != 0) output[dstoffs++] = data[Offs++];
                    else
                    {
                        byte b = data[Offs++];
                        int offs = ((b & 0xF) << 8 | data[Offs++]) + 1;
                        int length = (b >> 4) + 2;
                        if (length == 2) length = data[Offs++] + 0x12;
                        for (int j = 0; j < length; j++)
                        {
                            output[dstoffs] = output[dstoffs - offs];
                            dstoffs++;
                        }
                    }
                    if (dstoffs >= decompSize)
                    {
                        Array.Resize(ref data, decompSize);
                        output.CopyTo(data, 0);
                        return;
                    }
                    header <<= 1;
                }
            }
        }
    }
}
