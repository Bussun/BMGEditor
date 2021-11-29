namespace BMGEditor.UI
{
    partial class TextEntryEditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.entryNoGroup = new System.Windows.Forms.GroupBox();
            this.entryNoTextBox = new System.Windows.Forms.TextBox();
            this.entryNameGroup = new System.Windows.Forms.GroupBox();
            this.entryNameTxtBox = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.entryTextTxtBox = new System.Windows.Forms.RichTextBox();
            this.unk1ValueGroup = new System.Windows.Forms.GroupBox();
            this.cameraOptGroup = new System.Windows.Forms.GroupBox();
            this.sndEffectOptGroup = new System.Windows.Forms.GroupBox();
            this.unk2ValueGroup = new System.Windows.Forms.GroupBox();
            this.msgTriggerGroup = new System.Windows.Forms.GroupBox();
            this.msgLayoutGroup = new System.Windows.Forms.GroupBox();
            this.msgAreaGroup = new System.Windows.Forms.GroupBox();
            this.unk1ValueUpDown = new System.Windows.Forms.NumericUpDown();
            this.cameraOptUpDown = new System.Windows.Forms.NumericUpDown();
            this.sndEffectOptUpDown = new System.Windows.Forms.NumericUpDown();
            this.unk2ValueUpDown = new System.Windows.Forms.NumericUpDown();
            this.msgTriggerCombo = new System.Windows.Forms.ComboBox();
            this.msgLayoutCombo = new System.Windows.Forms.ComboBox();
            this.msgAreaCombo = new System.Windows.Forms.ComboBox();
            this.tabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.entryNoGroup.SuspendLayout();
            this.entryNameGroup.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.unk1ValueGroup.SuspendLayout();
            this.cameraOptGroup.SuspendLayout();
            this.sndEffectOptGroup.SuspendLayout();
            this.unk2ValueGroup.SuspendLayout();
            this.msgTriggerGroup.SuspendLayout();
            this.msgLayoutGroup.SuspendLayout();
            this.msgAreaGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unk1ValueUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraOptUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sndEffectOptUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unk2ValueUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 450);
            this.tabControl.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.flowLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Properties";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.entryNameGroup);
            this.flowLayoutPanel1.Controls.Add(this.entryNoGroup);
            this.flowLayoutPanel1.Controls.Add(this.unk1ValueGroup);
            this.flowLayoutPanel1.Controls.Add(this.cameraOptGroup);
            this.flowLayoutPanel1.Controls.Add(this.sndEffectOptGroup);
            this.flowLayoutPanel1.Controls.Add(this.unk2ValueGroup);
            this.flowLayoutPanel1.Controls.Add(this.msgTriggerGroup);
            this.flowLayoutPanel1.Controls.Add(this.msgLayoutGroup);
            this.flowLayoutPanel1.Controls.Add(this.msgAreaGroup);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(786, 411);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // entryNoGroup
            // 
            this.entryNoGroup.Controls.Add(this.entryNoTextBox);
            this.entryNoGroup.Location = new System.Drawing.Point(196, 3);
            this.entryNoGroup.Name = "entryNoGroup";
            this.entryNoGroup.Size = new System.Drawing.Size(187, 66);
            this.entryNoGroup.TabIndex = 1;
            this.entryNoGroup.TabStop = false;
            this.entryNoGroup.Text = "Entry number";
            // 
            // entryNoTextBox
            // 
            this.entryNoTextBox.Enabled = false;
            this.entryNoTextBox.Location = new System.Drawing.Point(6, 26);
            this.entryNoTextBox.Name = "entryNoTextBox";
            this.entryNoTextBox.Size = new System.Drawing.Size(167, 27);
            this.entryNoTextBox.TabIndex = 0;
            // 
            // entryNameGroup
            // 
            this.entryNameGroup.Controls.Add(this.entryNameTxtBox);
            this.entryNameGroup.Location = new System.Drawing.Point(3, 3);
            this.entryNameGroup.Name = "entryNameGroup";
            this.entryNameGroup.Size = new System.Drawing.Size(187, 66);
            this.entryNameGroup.TabIndex = 0;
            this.entryNameGroup.TabStop = false;
            this.entryNameGroup.Text = "Entry name";
            // 
            // entryNameTxtBox
            // 
            this.entryNameTxtBox.Enabled = false;
            this.entryNameTxtBox.Location = new System.Drawing.Point(6, 26);
            this.entryNameTxtBox.Name = "entryNameTxtBox";
            this.entryNameTxtBox.Size = new System.Drawing.Size(167, 27);
            this.entryNameTxtBox.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.entryTextTxtBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Text";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // entryTextTxtBox
            // 
            this.entryTextTxtBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entryTextTxtBox.Location = new System.Drawing.Point(3, 3);
            this.entryTextTxtBox.Name = "entryTextTxtBox";
            this.entryTextTxtBox.Size = new System.Drawing.Size(786, 411);
            this.entryTextTxtBox.TabIndex = 7;
            this.entryTextTxtBox.Text = "";
            // 
            // unk1ValueGroup
            // 
            this.unk1ValueGroup.Controls.Add(this.unk1ValueUpDown);
            this.unk1ValueGroup.Location = new System.Drawing.Point(389, 3);
            this.unk1ValueGroup.Name = "unk1ValueGroup";
            this.unk1ValueGroup.Size = new System.Drawing.Size(187, 66);
            this.unk1ValueGroup.TabIndex = 2;
            this.unk1ValueGroup.TabStop = false;
            this.unk1ValueGroup.Text = "Unknown value 1";
            // 
            // cameraOptGroup
            // 
            this.cameraOptGroup.Controls.Add(this.cameraOptUpDown);
            this.cameraOptGroup.Location = new System.Drawing.Point(582, 3);
            this.cameraOptGroup.Name = "cameraOptGroup";
            this.cameraOptGroup.Size = new System.Drawing.Size(187, 66);
            this.cameraOptGroup.TabIndex = 2;
            this.cameraOptGroup.TabStop = false;
            this.cameraOptGroup.Text = "Camera";
            // 
            // sndEffectOptGroup
            // 
            this.sndEffectOptGroup.Controls.Add(this.sndEffectOptUpDown);
            this.sndEffectOptGroup.Location = new System.Drawing.Point(3, 75);
            this.sndEffectOptGroup.Name = "sndEffectOptGroup";
            this.sndEffectOptGroup.Size = new System.Drawing.Size(187, 66);
            this.sndEffectOptGroup.TabIndex = 2;
            this.sndEffectOptGroup.TabStop = false;
            this.sndEffectOptGroup.Text = "Sound effect";
            // 
            // unk2ValueGroup
            // 
            this.unk2ValueGroup.Controls.Add(this.unk2ValueUpDown);
            this.unk2ValueGroup.Location = new System.Drawing.Point(196, 75);
            this.unk2ValueGroup.Name = "unk2ValueGroup";
            this.unk2ValueGroup.Size = new System.Drawing.Size(187, 66);
            this.unk2ValueGroup.TabIndex = 3;
            this.unk2ValueGroup.TabStop = false;
            this.unk2ValueGroup.Text = "Unknown value 2";
            // 
            // msgTriggerGroup
            // 
            this.msgTriggerGroup.Controls.Add(this.msgTriggerCombo);
            this.msgTriggerGroup.Location = new System.Drawing.Point(389, 75);
            this.msgTriggerGroup.Name = "msgTriggerGroup";
            this.msgTriggerGroup.Size = new System.Drawing.Size(187, 66);
            this.msgTriggerGroup.TabIndex = 4;
            this.msgTriggerGroup.TabStop = false;
            this.msgTriggerGroup.Text = "Message trigger";
            // 
            // msgLayoutGroup
            // 
            this.msgLayoutGroup.Controls.Add(this.msgLayoutCombo);
            this.msgLayoutGroup.Location = new System.Drawing.Point(582, 75);
            this.msgLayoutGroup.Name = "msgLayoutGroup";
            this.msgLayoutGroup.Size = new System.Drawing.Size(187, 66);
            this.msgLayoutGroup.TabIndex = 5;
            this.msgLayoutGroup.TabStop = false;
            this.msgLayoutGroup.Text = "Message layout";
            // 
            // msgAreaGroup
            // 
            this.msgAreaGroup.Controls.Add(this.msgAreaCombo);
            this.msgAreaGroup.Location = new System.Drawing.Point(3, 147);
            this.msgAreaGroup.Name = "msgAreaGroup";
            this.msgAreaGroup.Size = new System.Drawing.Size(187, 66);
            this.msgAreaGroup.TabIndex = 6;
            this.msgAreaGroup.TabStop = false;
            this.msgAreaGroup.Text = "Message area";
            // 
            // unk1ValueUpDown
            // 
            this.unk1ValueUpDown.Hexadecimal = true;
            this.unk1ValueUpDown.Location = new System.Drawing.Point(6, 27);
            this.unk1ValueUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.unk1ValueUpDown.Name = "unk1ValueUpDown";
            this.unk1ValueUpDown.Size = new System.Drawing.Size(167, 27);
            this.unk1ValueUpDown.TabIndex = 0;
            // 
            // cameraOptUpDown
            // 
            this.cameraOptUpDown.Hexadecimal = true;
            this.cameraOptUpDown.Location = new System.Drawing.Point(6, 26);
            this.cameraOptUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.cameraOptUpDown.Name = "cameraOptUpDown";
            this.cameraOptUpDown.Size = new System.Drawing.Size(167, 27);
            this.cameraOptUpDown.TabIndex = 1;
            // 
            // sndEffectOptUpDown
            // 
            this.sndEffectOptUpDown.Hexadecimal = true;
            this.sndEffectOptUpDown.Location = new System.Drawing.Point(6, 26);
            this.sndEffectOptUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.sndEffectOptUpDown.Name = "sndEffectOptUpDown";
            this.sndEffectOptUpDown.Size = new System.Drawing.Size(167, 27);
            this.sndEffectOptUpDown.TabIndex = 1;
            // 
            // unk2ValueUpDown
            // 
            this.unk2ValueUpDown.Hexadecimal = true;
            this.unk2ValueUpDown.Location = new System.Drawing.Point(6, 26);
            this.unk2ValueUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.unk2ValueUpDown.Name = "unk2ValueUpDown";
            this.unk2ValueUpDown.Size = new System.Drawing.Size(167, 27);
            this.unk2ValueUpDown.TabIndex = 1;
            // 
            // msgTriggerCombo
            // 
            this.msgTriggerCombo.FormattingEnabled = true;
            this.msgTriggerCombo.Items.AddRange(new object[] {
            "Talk",
            "Shout",
            "Auto",
            "Unknown",
            "None"});
            this.msgTriggerCombo.Location = new System.Drawing.Point(6, 26);
            this.msgTriggerCombo.Name = "msgTriggerCombo";
            this.msgTriggerCombo.Size = new System.Drawing.Size(167, 28);
            this.msgTriggerCombo.TabIndex = 0;
            // 
            // msgLayoutCombo
            // 
            this.msgLayoutCombo.FormattingEnabled = true;
            this.msgLayoutCombo.Items.AddRange(new object[] {
            "Default",
            "Reading a sign",
            "Information"});
            this.msgLayoutCombo.Location = new System.Drawing.Point(6, 25);
            this.msgLayoutCombo.Name = "msgLayoutCombo";
            this.msgLayoutCombo.Size = new System.Drawing.Size(167, 28);
            this.msgLayoutCombo.TabIndex = 1;
            // 
            // msgAreaCombo
            // 
            this.msgAreaCombo.FormattingEnabled = true;
            this.msgAreaCombo.Items.AddRange(new object[] {
            "0x00 (Unknown)",
            "0xFF (Unknown)"});
            this.msgAreaCombo.Location = new System.Drawing.Point(6, 26);
            this.msgAreaCombo.Name = "msgAreaCombo";
            this.msgAreaCombo.Size = new System.Drawing.Size(167, 28);
            this.msgAreaCombo.TabIndex = 2;
            // 
            // TextEntryEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "TextEntryEditorForm";
            this.Text = "TextEntryEditorForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TextEntryEditorForm_FormClosing);
            this.tabControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.entryNoGroup.ResumeLayout(false);
            this.entryNoGroup.PerformLayout();
            this.entryNameGroup.ResumeLayout(false);
            this.entryNameGroup.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.unk1ValueGroup.ResumeLayout(false);
            this.cameraOptGroup.ResumeLayout(false);
            this.sndEffectOptGroup.ResumeLayout(false);
            this.unk2ValueGroup.ResumeLayout(false);
            this.msgTriggerGroup.ResumeLayout(false);
            this.msgLayoutGroup.ResumeLayout(false);
            this.msgAreaGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.unk1ValueUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraOptUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sndEffectOptUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unk2ValueUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox entryTextTxtBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox entryNameGroup;
        private System.Windows.Forms.TextBox entryNameTxtBox;
        private System.Windows.Forms.GroupBox entryNoGroup;
        private System.Windows.Forms.TextBox entryNoTextBox;
        private System.Windows.Forms.GroupBox unk1ValueGroup;
        private System.Windows.Forms.NumericUpDown unk1ValueUpDown;
        private System.Windows.Forms.GroupBox cameraOptGroup;
        private System.Windows.Forms.NumericUpDown cameraOptUpDown;
        private System.Windows.Forms.GroupBox sndEffectOptGroup;
        private System.Windows.Forms.NumericUpDown sndEffectOptUpDown;
        private System.Windows.Forms.GroupBox unk2ValueGroup;
        private System.Windows.Forms.NumericUpDown unk2ValueUpDown;
        private System.Windows.Forms.GroupBox msgTriggerGroup;
        private System.Windows.Forms.ComboBox msgTriggerCombo;
        private System.Windows.Forms.GroupBox msgLayoutGroup;
        private System.Windows.Forms.ComboBox msgLayoutCombo;
        private System.Windows.Forms.GroupBox msgAreaGroup;
        private System.Windows.Forms.ComboBox msgAreaCombo;
    }
}