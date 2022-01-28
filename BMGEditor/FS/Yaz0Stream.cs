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
            
            return;
        }
    }
}
