using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMGEditor
{
    public partial class PreferencesAbout : Form
    {
        public PreferencesAbout()
        {
            InitializeComponent();
            Text = "About this software";
            label3.Text = $"Version: {Variables.softwareVersion}";
            label4.Text = $"Build number: {Variables.build}";
        }

        private void closeFormBtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void checkUpdateBtn_Click(object sender, EventArgs e)
        {
            Program.CheckUpdates();
        }
    }
}
