using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;
using System.Globalization;
using System.Net.Http;
using System.IO;
using System.Threading;

namespace BMGEditor
{
    public static class Variables
    {
        public const string softwareName = "Luma";
        public const string softwareVersion = "v0.4.5";
        public const UInt64 softwareInternalVersion = 45;
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
            if (Variables.isBeta && Variables.isPrivateBeta) 
                MessageBox.Show("This is a private beta, please don\'t leak it.", "Private", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Application.Run(new MainForm());
        }

        static readonly HttpClient wrClient = new HttpClient();
        public static async void CheckUpdates()
        {
            const string verCheckURL = "https://bussun.github.io/res/checks/luma/upre1";
            Stream wrAnswer;

            try
            {
                wrAnswer = await wrClient.GetStreamAsync(verCheckURL);
                StreamReader wrAnswerReader = new StreamReader(wrAnswer);
                string wrAnswerContent = wrAnswerReader.ReadToEnd();
                
                if (wrAnswerContent.Length != 0)
                {
                    UInt64 wrAnswerVersion = UInt64.Parse(wrAnswerContent);

                    if (wrAnswerVersion > Variables.softwareInternalVersion)
                        MessageBox.Show("New version available", "Update available", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else if (wrAnswerVersion == Variables.softwareInternalVersion)
                        MessageBox.Show("Luma is up to date.", "No update available", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Woah, you got a developpement version !", "The most up to date ever (for now)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Couldn\'t check for updates, null response", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Couldn\'t check for updates", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}