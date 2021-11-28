using BMGEditor.UI;
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
    public partial class BMGEditForm : Form
    {
        public BMGEditForm(RarcFilesystem arcFs)
        {
            InitializeComponent();
            Text = $"Text editor - {Variables.softwareName} {Variables.softwareVersion}";
            if (Variables.isBeta) Text += " [BETA]";

            m_FileTbl = new Bcsv(arcFs.OpenFile($"{arcFs.rootName}/messageid.tbl"));
            m_File = new BMG(arcFs.OpenFile($"{arcFs.rootName}/message.bmg"), m_FileTbl);

            foreach (BMG.TextEntry txtEntry in m_File.Entries)
            {
                entriesListBox.Items.Add(txtEntry.entryName);
            }
        }

        private BMG m_File = null;
        private Bcsv m_FileTbl = null;

        private void BMGEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_File.Close();
            m_FileTbl.Close();
        }

        private void openEntryBtn_Click(object sender, EventArgs e)
        {
            Form txtEditForm = new TextEntryEditorForm(m_File.Entries[entriesListBox.SelectedIndex]);
            txtEditForm.Show();
        }

        private void addEntryBtn_Click(object sender, EventArgs e)
        {
            Form newEntryForm = new NewEntryForm();
            newEntryForm.Show();
        }

        private void deleteEntryBtn_Click(object sender, EventArgs e)
        {
            m_File.NukeFile();
        }
    }
}
