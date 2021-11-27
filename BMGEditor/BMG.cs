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
        private Int32 m_Signature = 0x4D455347;
        private Int32 m_FileType = 0x626D6731;
        private Byte m_ExpectedEncoding = 0x02;

        public BMG(FileBase file)
        {
            m_File = file;
            m_File.BigEndian = true;
            m_File.Stream.Position = 0;

            Int32 headermagic1 = m_File.Reader.ReadInt32();
            Int32 headermagic2 = m_File.Reader.ReadInt32();
            if (headermagic1 == m_Signature && headermagic2 == m_FileType) { Console.WriteLine("Nice"); } else { Console.WriteLine("not nice");}

            UInt32 fileSize = m_File.Reader.ReadUInt32();
            UInt32 numberOfSections = m_File.Reader.ReadUInt32();
            Byte fileEncoding = m_File.Reader.ReadByte();
            Console.WriteLine("File size: " + fileSize);
            Console.WriteLine("File sections: " + numberOfSections);



        }

        public void Close()
        {
            m_File.Close();
        }
    }

    /*public class BMGSection
    {
        Int32 sectionMagic;
        public BMGSection()
        {

        }
    }

    public class INF1Section : BMGSection
    {
        public INF1Section()
        {
            
        }
    }*/
}
