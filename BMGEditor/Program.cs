using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BMGEditor
{
    public static class Variables
    {
        public const string softwareName = "Luma";
        public const string softwareVersion = "v0.1";
        public const bool isBeta = true;
        public const bool isPrivateBeta = true;
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
        }
    }
}