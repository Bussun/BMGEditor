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
            this.entryNameTxtBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.sndEffectCombo = new System.Windows.Forms.ComboBox();
            this.msgLayoutCombo = new System.Windows.Forms.ComboBox();
            this.msgTriggerCombo = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // entryNameTxtBox
            // 
            this.entryNameTxtBox.Location = new System.Drawing.Point(538, 327);
            this.entryNameTxtBox.Name = "entryNameTxtBox";
            this.entryNameTxtBox.Size = new System.Drawing.Size(125, 27);
            this.entryNameTxtBox.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(538, 121);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(538, 71);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 27);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(538, 24);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(125, 27);
            this.textBox4.TabIndex = 3;
            // 
            // sndEffectCombo
            // 
            this.sndEffectCombo.FormattingEnabled = true;
            this.sndEffectCombo.Location = new System.Drawing.Point(512, 265);
            this.sndEffectCombo.Name = "sndEffectCombo";
            this.sndEffectCombo.Size = new System.Drawing.Size(151, 28);
            this.sndEffectCombo.TabIndex = 4;
            // 
            // msgLayoutCombo
            // 
            this.msgLayoutCombo.FormattingEnabled = true;
            this.msgLayoutCombo.Location = new System.Drawing.Point(512, 213);
            this.msgLayoutCombo.Name = "msgLayoutCombo";
            this.msgLayoutCombo.Size = new System.Drawing.Size(151, 28);
            this.msgLayoutCombo.TabIndex = 5;
            // 
            // msgTriggerCombo
            // 
            this.msgTriggerCombo.FormattingEnabled = true;
            this.msgTriggerCombo.Location = new System.Drawing.Point(512, 168);
            this.msgTriggerCombo.Name = "msgTriggerCombo";
            this.msgTriggerCombo.Size = new System.Drawing.Size(151, 28);
            this.msgTriggerCombo.TabIndex = 6;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(470, 410);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // TextEntryEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.msgTriggerCombo);
            this.Controls.Add(this.msgLayoutCombo);
            this.Controls.Add(this.sndEffectCombo);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.entryNameTxtBox);
            this.Name = "TextEntryEditorForm";
            this.Text = "TextEntryEditorForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TextEntryEditorForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox entryNameTxtBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox sndEffectCombo;
        private System.Windows.Forms.ComboBox msgLayoutCombo;
        private System.Windows.Forms.ComboBox msgTriggerCombo;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}