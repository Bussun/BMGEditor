using System;
using System.Windows.Forms;

namespace BMGEditor
{
    partial class BMGEditForm
    {
        private void openEditor()
        {
            Form txtEditForm = new TextEntryEditorForm(m_File.Entries[entriesListBox.SelectedIndex]);
            txtEditForm.Show();
        }

        private void RefreshEntriesList()
        {
            entriesListBox.Items.Clear();
            foreach (BMG.TextEntry txtEntry in m_File.Entries)
            {
                entriesListBox.Items.Add(txtEntry.entryName);
            }
        }

        private void Save()
        {
            m_File.Entries.Sort((x, y) =>
            {
                string entryNameA = x.entryName, entryNameB = y.entryName;
                return String.CompareOrdinal(entryNameA, entryNameB);
            });

            m_BCSV.Entries.Clear();

            foreach (BMG.TextEntry txtEntry in m_File.Entries)
            {
                Bcsv.Entry entry = new Bcsv.Entry();
                m_BCSV.Entries.Add(entry);

                int index = 0;
                foreach (Bcsv.Field field in m_BCSV.Fields.Values)
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

            m_BCSV.Flush();
            m_File.Entries.Sort((x, y) =>
            {
                int entryIndexA = x.entryNo, entryIndexB = y.entryNo;
                return entryIndexA.CompareTo(entryIndexB);
            });

            m_File.WriteToFile();
        }
        private void CloseArchive()
        {
            m_File.Close();
            m_BCSV.Close();
            m_ARC.Close();
        }
    }
}
