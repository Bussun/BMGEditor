using BMGEditor.UI;
using System.IO;
using System;
using System.Windows.Forms;

namespace BMGEditor
{
    public partial class BMGEditForm : Form
    {
        private RarcFilesystem m_ARC = null;
        private BMG m_File = null;
        private Bcsv m_BCSV = null;
        private bool arcOpen = false;

        [Obsolete]
        public BMGEditForm(RarcFilesystem m_ARC)
        {
            InitializeComponent();
            Text = $"Text editor - {Variables.softwareName} {Variables.softwareVersion}";
            if (Variables.isBeta) Text += " [BETA]";
            
            deleteEntryBtn.Enabled = false;
        }

        public BMGEditForm()
        {
            InitializeComponent();
            Text = $"{Variables.softwareName} {Variables.softwareVersion}";
            if (Variables.isBeta) Text += " [BETA]";

            openBCSVBtn.Enabled = false;
            openEntryBtn.Enabled = false;
            saveFileBtn.Enabled = false;
            newEntryBtn.Enabled = false;
            deleteEntryBtn.Enabled = false;
        }


        private void BMGEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (arcOpen)
                CloseArchive();
        }

        private void openEntryBtn_Click(object sender, EventArgs e)
        {
            if (entriesListBox.SelectedIndex != -1)
                openEditor();
        }

        private void addEntryBtn_Click(object sender, EventArgs e)
        {
            Form newEntryForm = new NewEntryForm(m_File);
            newEntryForm.ShowDialog();
            RefreshEntriesList();

        }

        private void deleteEntryBtn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void entriesListBox_DoubleClick(object sender, EventArgs e)
        {
            openEditor();
        }

        private void saveBMGbtn_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void openSettingsBtn_Click(object sender, EventArgs e)
        {
            Form settings = new PreferencesAbout();
            settings.Show();
        }

        private void openArcFileBtn_Click(object sender, EventArgs e)
        {
            if (arcOpen)
            {
                CloseArchive();
                entriesListBox.Items.Clear();
            }

            string fileName;
            if (openARCDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openARCDialog.FileName;
                File.Copy(fileName, fileName + ".backup", true);
                m_ARC = new RarcFilesystem(new ExternalFile(fileName, false));
                if (m_ARC.FileExists($"{m_ARC.rootName}/message.bmg") && m_ARC.FileExists($"{m_ARC.rootName}/messageid.tbl"))
                {

                }
                else
                {
                    MessageBox.Show(
                        "Selected archive doesn\'t contain all the required files. Please check your file.",
                        "Error while loading file",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    m_ARC.Close();
                    return;
                }
                arcOpen = true;
                m_BCSV = new Bcsv(m_ARC.OpenFile($"{m_ARC.rootName}/messageid.tbl"));
                m_File = new BMG(m_ARC.OpenFile($"{m_ARC.rootName}/message.bmg"), m_BCSV);
                RefreshEntriesList();

                saveFileBtn.Enabled = true;
                openEntryBtn.Enabled = true;
                newEntryBtn.Enabled = true;
                #if DEBUG
                openBCSVBtn.Enabled = true;
                #else
                #endif

            }
            else
                return;
        }

        private void openBCSVBtn_Click(object sender, EventArgs e)
        {
            Form bcsvEdit = new BcsvEditorForm(m_ARC);
            bcsvEdit.Show();
        }

        private void toggleBEBtn_Click(object sender, EventArgs e)
        {
            Tests.isBE = !Tests.isBE;
            MessageBox.Show("Switched successfully");
        }
    }
}
