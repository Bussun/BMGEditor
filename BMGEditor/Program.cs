using System;
using System.Windows.Forms;
using System.Net.Http;
using System.IO;

namespace BMGEditor
{
    public static class Variables
    {
        public const string softwareName = "Luma";
        public const string softwareVersion = "build 3";
        public const UInt64 build = 3;
        public const bool isBeta = true;
    }

    public static class Tests
    {
        //Not a good place to put this I know but I'm trying to figure it out
        public static bool isBE = false;
    }
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Bcsv.PopulateHashtable();
            Application.Run(new BMGEditForm());
        }

        static readonly HttpClient wrClient = new HttpClient();
        public static async void CheckUpdates()
        {
            string verCheckURL;
            if (Variables.isBeta)
              verCheckURL = "https://bussun.github.io/res/checks/luma/ub";
            else
              verCheckURL = "https://bussun.github.io/res/checks/luma/u";

            Stream wrAnswer;

            try
            {
                wrAnswer = await wrClient.GetStreamAsync(verCheckURL);
                StreamReader wrAnswerReader = new StreamReader(wrAnswer);
                string wrAnswerContent = wrAnswerReader.ReadToEnd();
                
                if (wrAnswerContent.Length != 0)
                {
                    UInt64 wrAnswerVersion = UInt64.Parse(wrAnswerContent);

                    if (wrAnswerVersion > Variables.build)
                        MessageBox.Show("New version available", "Update available", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else if (wrAnswerVersion == Variables.build)
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