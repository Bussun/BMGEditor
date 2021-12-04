namespace BMGEditor
{
    partial class BMGEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BMGEditForm));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripSplitButton();
            this.openArcFileBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.openSettingsBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.quitBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.editBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.openEntryBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.newEntryBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.openBCSVBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEntryBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.entriesListBox = new System.Windows.Forms.ListBox();
            this.openARCDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.White;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editBtn});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(700, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openArcFileBtn,
            this.saveFileBtn,
            this.openSettingsBtn,
            this.quitBtn});
            this.fileMenu.Image = ((System.Drawing.Image)(resources.GetObject("fileMenu.Image")));
            this.fileMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(41, 22);
            this.fileMenu.Text = "File";
            // 
            // openArcFileBtn
            // 
            this.openArcFileBtn.Name = "openArcFileBtn";
            this.openArcFileBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openArcFileBtn.Size = new System.Drawing.Size(180, 22);
            this.openArcFileBtn.Text = "Open";
            this.openArcFileBtn.Click += new System.EventHandler(this.openArcFileBtn_Click);
            // 
            // saveFileBtn
            // 
            this.saveFileBtn.Name = "saveFileBtn";
            this.saveFileBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveFileBtn.Size = new System.Drawing.Size(180, 22);
            this.saveFileBtn.Text = "Save";
            this.saveFileBtn.Click += new System.EventHandler(this.saveBMGbtn_Click);
            // 
            // openSettingsBtn
            // 
            this.openSettingsBtn.Name = "openSettingsBtn";
            this.openSettingsBtn.Size = new System.Drawing.Size(180, 22);
            this.openSettingsBtn.Text = "Preferences";
            this.openSettingsBtn.Click += new System.EventHandler(this.openSettingsBtn_Click);
            // 
            // quitBtn
            // 
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitBtn.Size = new System.Drawing.Size(180, 22);
            this.quitBtn.Text = "Quit";
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.editBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openEntryBtn,
            this.newEntryBtn,
            this.openBCSVBtn,
            this.deleteEntryBtn});
            this.editBtn.Image = ((System.Drawing.Image)(resources.GetObject("editBtn.Image")));
            this.editBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(40, 22);
            this.editBtn.Text = "Edit";
            // 
            // openEntryBtn
            // 
            this.openEntryBtn.Name = "openEntryBtn";
            this.openEntryBtn.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.openEntryBtn.Size = new System.Drawing.Size(238, 22);
            this.openEntryBtn.Text = "Open Entry";
            this.openEntryBtn.Click += new System.EventHandler(this.openEntryBtn_Click);
            // 
            // newEntryBtn
            // 
            this.newEntryBtn.Name = "newEntryBtn";
            this.newEntryBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newEntryBtn.Size = new System.Drawing.Size(238, 22);
            this.newEntryBtn.Text = "New Entry";
            this.newEntryBtn.Click += new System.EventHandler(this.addEntryBtn_Click);
            // 
            // openBCSVBtn
            // 
            this.openBCSVBtn.Enabled = false;
            this.openBCSVBtn.Name = "openBCSVBtn";
            this.openBCSVBtn.Size = new System.Drawing.Size(238, 22);
            this.openBCSVBtn.Text = "Open BCSV [DEBUG ONLY]";
            this.openBCSVBtn.Click += new System.EventHandler(this.openBCSVBtn_Click);
            // 
            // deleteEntryBtn
            // 
            this.deleteEntryBtn.Name = "deleteEntryBtn";
            this.deleteEntryBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.deleteEntryBtn.Size = new System.Drawing.Size(238, 22);
            this.deleteEntryBtn.Text = "Delete Entry";
            this.deleteEntryBtn.Click += new System.EventHandler(this.deleteEntryBtn_Click);
            // 
            // entriesListBox
            // 
            this.entriesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entriesListBox.FormattingEnabled = true;
            this.entriesListBox.ItemHeight = 15;
            this.entriesListBox.Location = new System.Drawing.Point(0, 25);
            this.entriesListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.entriesListBox.Name = "entriesListBox";
            this.entriesListBox.Size = new System.Drawing.Size(700, 313);
            this.entriesListBox.TabIndex = 1;
            this.entriesListBox.DoubleClick += new System.EventHandler(this.entriesListBox_DoubleClick);
            // 
            // openARCDialog
            // 
            this.openARCDialog.FileName = "Message.arc";
            this.openARCDialog.Filter = "Nintendo ARC Files|*.arc";
            this.openARCDialog.Title = "Open ARC";
            // 
            // BMGEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.entriesListBox);
            this.Controls.Add(this.toolStrip);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BMGEditForm";
            this.Text = "BMGEditForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BMGEditForm_FormClosing);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ListBox entriesListBox;
        private System.Windows.Forms.ToolStripSplitButton fileMenu;
        private System.Windows.Forms.ToolStripMenuItem openArcFileBtn;
        private System.Windows.Forms.ToolStripMenuItem saveFileBtn;
        private System.Windows.Forms.ToolStripMenuItem quitBtn;
        private System.Windows.Forms.ToolStripDropDownButton editBtn;
        private System.Windows.Forms.ToolStripMenuItem newEntryBtn;
        private System.Windows.Forms.ToolStripMenuItem deleteEntryBtn;
        private System.Windows.Forms.ToolStripMenuItem openEntryBtn;
        private System.Windows.Forms.ToolStripMenuItem openSettingsBtn;
        private System.Windows.Forms.ToolStripMenuItem openBCSVBtn;
        private System.Windows.Forms.OpenFileDialog openARCDialog;
    }
}