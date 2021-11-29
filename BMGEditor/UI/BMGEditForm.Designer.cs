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
            this.saveBMGbtn = new System.Windows.Forms.ToolStripButton();
            this.openEntryBtn = new System.Windows.Forms.ToolStripButton();
            this.deleteEntryBtn = new System.Windows.Forms.ToolStripButton();
            this.addEntryBtn = new System.Windows.Forms.ToolStripButton();
            this.entriesListBox = new System.Windows.Forms.ListBox();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveBMGbtn,
            this.openEntryBtn,
            this.deleteEntryBtn,
            this.addEntryBtn});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(800, 27);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip";
            // 
            // saveBMGbtn
            // 
            this.saveBMGbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.saveBMGbtn.Image = ((System.Drawing.Image)(resources.GetObject("saveBMGbtn.Image")));
            this.saveBMGbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveBMGbtn.Name = "saveBMGbtn";
            this.saveBMGbtn.Size = new System.Drawing.Size(44, 24);
            this.saveBMGbtn.Text = "Save";
            this.saveBMGbtn.ToolTipText = "Save";
            this.saveBMGbtn.Click += new System.EventHandler(this.saveBMGbtn_Click);
            // 
            // openEntryBtn
            // 
            this.openEntryBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.openEntryBtn.Image = ((System.Drawing.Image)(resources.GetObject("openEntryBtn.Image")));
            this.openEntryBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openEntryBtn.Name = "openEntryBtn";
            this.openEntryBtn.Size = new System.Drawing.Size(86, 24);
            this.openEntryBtn.Text = "Open entry";
            this.openEntryBtn.Click += new System.EventHandler(this.openEntryBtn_Click);
            // 
            // deleteEntryBtn
            // 
            this.deleteEntryBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.deleteEntryBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteEntryBtn.Image")));
            this.deleteEntryBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteEntryBtn.Name = "deleteEntryBtn";
            this.deleteEntryBtn.Size = new System.Drawing.Size(94, 24);
            this.deleteEntryBtn.Text = "Delete entry";
            this.deleteEntryBtn.Click += new System.EventHandler(this.deleteEntryBtn_Click);
            // 
            // addEntryBtn
            // 
            this.addEntryBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addEntryBtn.Image = ((System.Drawing.Image)(resources.GetObject("addEntryBtn.Image")));
            this.addEntryBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addEntryBtn.Name = "addEntryBtn";
            this.addEntryBtn.Size = new System.Drawing.Size(109, 24);
            this.addEntryBtn.Text = "Add new entry";
            this.addEntryBtn.Click += new System.EventHandler(this.addEntryBtn_Click);
            // 
            // entriesListBox
            // 
            this.entriesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entriesListBox.FormattingEnabled = true;
            this.entriesListBox.ItemHeight = 20;
            this.entriesListBox.Location = new System.Drawing.Point(0, 27);
            this.entriesListBox.Name = "entriesListBox";
            this.entriesListBox.Size = new System.Drawing.Size(800, 423);
            this.entriesListBox.TabIndex = 1;
            this.entriesListBox.DoubleClick += new System.EventHandler(this.entriesListBox_DoubleClick);
            // 
            // BMGEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.entriesListBox);
            this.Controls.Add(this.toolStrip);
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
        private System.Windows.Forms.ToolStripButton openEntryBtn;
        private System.Windows.Forms.ToolStripButton deleteEntryBtn;
        private System.Windows.Forms.ToolStripButton addEntryBtn;
        private System.Windows.Forms.ListBox entriesListBox;
        private System.Windows.Forms.ToolStripButton saveBMGbtn;
    }
}