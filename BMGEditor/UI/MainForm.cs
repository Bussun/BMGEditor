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
    public partial class MainForm : Form
    {
        RarcFilesystem arc;
        bool arcOpen = false;

        public MainForm()
        {
            InitializeComponent();
            Text = $"{Variables.softwareName} {Variables.softwareVersion}";
            if (Variables.isBeta) this.Text += " [BETA]";
        }

        private void openBcsvEditorBtn_Click(object sender, EventArgs e)
        {
            Form bcsvEdit = new BcsvEditorForm(arc);
            bcsvEdit.Show();
        }

        private void openFileBtn_Click(object sender, EventArgs e)
        {
            if (arcOpen) { 
                MessageBox.Show("Please close the current file first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string fileName;
            if (openARCFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openARCFileDialog.FileName;
                arc = new RarcFilesystem(new ExternalFile(fileName, false));
                if (arc.FileExists($"{arc.rootName}/message.bmg") && arc.FileExists($"{arc.rootName}/messageid.tbl"))
                {
                    
                }
                else
                {
                    MessageBox.Show(
                        "Selected archive doesn\'t contain all the required files. Please check your file.",
                        "Error while loading file",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    arc.Close();
                    return;
                }

                #if DEBUG
                    openBcsvEditorBtn.Enabled = true;
                #else
                #endif
                openTextEditorBtn.Enabled = true;
                closeFileBtn.Enabled = true;
                arcOpen = true;
            }
            else
                return;
        }

        private void closeFileBtn_Click(object sender, EventArgs e)
        {
            arc.Close();
            arcOpen = false;
            openBcsvEditorBtn.Enabled = false;
            openTextEditorBtn.Enabled = false;
            closeFileBtn.Enabled = false;
        }

        private void openTextEditorBtn_Click(object sender, EventArgs e)
        {
            Form bmgEdit = new BMGEditForm(arc);
            bmgEdit.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BMG Editor by Bussun", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void updateCheckBtn_Click(object sender, EventArgs e)
        {
            Program.CheckUpdates();
        }
    }
}
