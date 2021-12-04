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
        public const string softwareVersion = "v0.6";
        public const UInt64 softwareInternalVersion = 60;
        public const UInt64 build = 1; //Getting ready for 1.0
        public const bool isBeta = true;
    }
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Bcsv.PopulateHashtable();
            CheckUpdates();
            Application.Run(new MainForm());
        }

        static readonly HttpClient wrClient = new HttpClient();
        public static async void CheckUpdates()
        {
            const string verCheckURL = "https://bussun.github.io/res/checks/luma/upre1";
            /*if (Variables.isBeta)
             *  const string verCheckURL = "https://bussun.github.io/res/checks/luma/ub";
             *else
             *  const string verCheckURL = "https://bussun.github.io/res/chacks/luma/u";
             */ //Getting ready for 1.0 
            Stream wrAnswer;

            try
            {
                wrAnswer = await wrClient.GetStreamAsync(verCheckURL);
                StreamReader wrAnswerReader = new StreamReader(wrAnswer);
                string wrAnswerContent = wrAnswerReader.ReadToEnd();
                
                if (wrAnswerContent.Length != 0)
                {
                    UInt64 wrAnswerVersion = UInt64.Parse(wrAnswerContent);

                    if (wrAnswerVersion == 100)
                        MessageBox.Show("The 1.0 release is available !!", "1.0 Available, upgrade now !");
                    else if (wrAnswerVersion > Variables.softwareInternalVersion)
                        MessageBox.Show("New version available", "Update available", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else if (wrAnswerVersion == Variables.softwareInternalVersion)
                        MessageBox.Show("Luma is up to date.", "No update available", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Woah, you got a developpement version !", "The most up to date ever (for now)", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    /* if (wrAnswerVersion > Variables.build)
                        MessageBox.Show("New version available", "Update available", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else if (wrAnswerVersion == Variables.build)
                        MessageBox.Show("Luma is up to date.", "No update available", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Woah, you got a developpement version !", "The most up to date ever (for now)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    */ //Getting ready for 1.0
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