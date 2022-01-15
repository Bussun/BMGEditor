using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace BMGEditor
{
    public class Yaz0Stream : MemoryStream //ONLY WORKS WITH BIG ENDIAN - TO REWRITE !!
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
}
