using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;
using System.Globalization;

namespace BMGEditor
{
    public static class Variables
    {
        public const string softwareName = "Luma";
        public const string softwareVersion = "v0.1";
        public const bool isBeta = true;
        public const bool isPrivateBeta = false;
    }
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Bcsv.PopulateHashtable();
            if (Variables.isBeta && Variables.isPrivateBeta) MessageBox.Show("This is a private beta, please don\'t leak it.", "Private", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Application.Run(new MainForm());

            //Test();
        }

        static void Test()
        {
            string str = "FF";
            Byte octet = Byte.Parse(str, NumberStyles.HexNumber);
            Console.WriteLine(octet);
            
        }
    }
}