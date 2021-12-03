using System;
using System.Windows.Forms;

namespace BMGEditor.UI
{
    public partial class NewEntryForm : Form
    {
        private BMG m_File;
        public NewEntryForm(BMG file)
        {
            InitializeComponent();
            Text = "New Entry";
            m_File = file;
        }

        private void createEntryBtn_Click(object sender, EventArgs e)
        {
            if (newEntryNameTxtBox.Text == "") { }
            else
            {
                m_File.AddNewEntry(newEntryNameTxtBox.Text);
                this.Dispose();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
