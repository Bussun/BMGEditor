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
    public partial class TextEntryEditorForm : Form
    {
        BMG.TextEntry m_Entry;
        public TextEntryEditorForm(BMG.TextEntry txtEntry)
        {
            InitializeComponent();
            m_Entry = txtEntry;
            Text = $"Editing {m_Entry.entryName} - {Variables.softwareName} {Variables.softwareVersion}";
            if (Variables.isBeta) Text += " [BETA]";

            //Filling window with entry content
            entryTextTxtBox.Text = m_Entry.text;
            entryNameTxtBox.Text = m_Entry.entryName;
            entryNoTextBox.Text = String.Concat(m_Entry.entryNo);
            unk1ValueUpDown.Value = m_Entry.unk1;
            cameraOptUpDown.Value = m_Entry.cameraOpt;
            sndEffectOptUpDown.Value = m_Entry.sndEffectOpt;
            unk2ValueUpDown.Value = m_Entry.unk2;

            switch (m_Entry.messageTriggerOpt)
            {
                case 0x00:
                    msgTriggerCombo.SelectedIndex = 0x00;
                    break;

                case 0x01:
                    msgTriggerCombo.SelectedIndex = 0x01;
                    break;

                case 0x02:
                    msgTriggerCombo.SelectedIndex = 0x02;
                    break;

                case 0x04:
                    msgTriggerCombo.SelectedIndex = 0x03;
                    break;

                case 0x05:
                    msgTriggerCombo.SelectedIndex = 0x04;
                    break;
            }

            switch (m_Entry.messageLayoutOpt)
            {
                case 0x00:
                    msgLayoutCombo.SelectedItem = msgLayoutCombo.Items[0];
                    break;

                case 0x04:
                    msgLayoutCombo.SelectedItem = msgLayoutCombo.Items[1];
                    break;

                case 0x05:
                    msgLayoutCombo.SelectedItem = msgLayoutCombo.Items[2];
                    break;
            }

            switch (m_Entry.messageAreaOpt)
            {
                case 0x00:
                    msgAreaCombo.SelectedItem = msgAreaCombo.Items[0];
                    break;

                case 0xFF:
                    msgAreaCombo.SelectedItem = msgAreaCombo.Items[1];
                    break;
            }
        }

        private void TextEntryEditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Saving edited content
            m_Entry.text = entryTextTxtBox.Text;
            m_Entry.unk1 = (byte)unk1ValueUpDown.Value;
            m_Entry.cameraOpt = (byte)cameraOptUpDown.Value;
            m_Entry.sndEffectOpt = (byte)sndEffectOptUpDown.Value;
            m_Entry.unk2 = (byte)unk2ValueUpDown.Value;

            switch (msgTriggerCombo.SelectedIndex)
            {
                case 0x00:
                    m_Entry.messageTriggerOpt = 0x00;
                    break;

                case 0x01:
                    m_Entry.messageTriggerOpt = 0x01;
                    break;

                case 0x02:
                    m_Entry.messageTriggerOpt = 0x02;
                    break;

                case 0x03:
                    m_Entry.messageTriggerOpt = 0x04;
                    break;

                case 0x04:
                    m_Entry.messageTriggerOpt = 0x05;
                    break;
            }

            switch (msgLayoutCombo.SelectedIndex)
            {
                case 0x00:
                    m_Entry.messageLayoutOpt = 0x00;
                    break;

                case 0x01:
                    m_Entry.messageLayoutOpt = 0x04;
                    break;

                case 0x02:
                    m_Entry.messageLayoutOpt = 0x05;
                    break;
            }

            switch (msgAreaCombo.SelectedIndex)
            {
                case 0x00:
                    m_Entry.messageAreaOpt = 0x00;
                    break;

                case 0x01:
                    m_Entry.messageAreaOpt = 0xFF;
                    break;
            }
        }
    }
}
