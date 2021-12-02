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

            //addEntryBtn.Enabled = false;
            deleteEntryBtn.Enabled = false;
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
            if (entriesListBox.SelectedIndex == -1) { }
            else openEditor();
        }

        private void addEntryBtn_Click(object sender, EventArgs e)
        {
            Form newEntryForm = new NewEntryForm(m_File);
            newEntryForm.Show();

            entriesListBox.Items.Clear();
            foreach (BMG.TextEntry txtEntry in m_File.Entries)
            {
                entriesListBox.Items.Add(txtEntry.entryName);
            }

        }

        private void deleteEntryBtn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void openEditor()
        {
            Form txtEditForm = new TextEntryEditorForm(m_File.Entries[entriesListBox.SelectedIndex]);
            txtEditForm.Show();
        }

        private void entriesListBox_DoubleClick(object sender, EventArgs e)
        {
            openEditor();
        }

        private void saveBMGbtn_Click(object sender, EventArgs e)
        {
            m_File.Entries.Sort((x, y) =>
            {
                string entryNameA = x.entryName, entryNameB = y.entryName;
                return String.CompareOrdinal(entryNameA, entryNameB);
            });

            m_FileTbl.Entries.Clear();

            foreach (BMG.TextEntry txtEntry in m_File.Entries)
            {
                Bcsv.Entry entry = new Bcsv.Entry();
                m_FileTbl.Entries.Add(entry);

                int index = 0;
                foreach (Bcsv.Field field in m_FileTbl.Fields.Values)
                {
                    uint hash = field.NameHash;
                    string valstring;
                    if (index == 0)
                        valstring = txtEntry.entryName;
                    else
                        valstring = String.Concat(txtEntry.entryNo);

                    index++;


                    try
                    {
                        switch (field.Type)
                        {
                            case 0:
                            case 3: entry.Add(hash, uint.Parse(valstring)); break;
                            case 4: entry.Add(hash, ushort.Parse(valstring)); break;
                            case 5: entry.Add(hash, byte.Parse(valstring)); break;
                            case 2: entry.Add(hash, float.Parse(valstring)); break;
                            case 6: entry.Add(hash, valstring); break;
                        }
                    }
                    catch
                    {
                        switch (field.Type)
                        {
                            case 0:
                            case 3: entry.Add(hash, (uint)0); break;
                            case 4: entry.Add(hash, (ushort)0); break;
                            case 5: entry.Add(hash, (byte)0); break;
                            case 2: entry.Add(hash, 0f); break;
                            case 6: entry.Add(hash, ""); break;
                        }
                    }
                }
            }

            m_FileTbl.Flush();
            m_File.Entries.Sort((x, y) =>
            {
                int entryIndexA = x.entryNo, entryIndexB = y.entryNo;
                return entryIndexA.CompareTo(entryIndexB);
            });

            m_File.WriteToFile();
        }
    }
}
