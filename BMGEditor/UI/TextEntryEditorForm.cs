using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMGEditor.UI
{
    public partial class TextEntryEditorForm : Form
    {
        BMG.TextEntry m_Entry;
        public TextEntryEditorForm(BMG.TextEntry txtEntry)
        {
            InitializeComponent();
            m_Entry = txtEntry;
            richTextBox1.Text = m_Entry.text;
        }

        private void TextEntryEditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_Entry.text = richTextBox1.Text;
        }
    }
}
