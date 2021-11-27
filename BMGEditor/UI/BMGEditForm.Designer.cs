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
            this.panel1 = new System.Windows.Forms.Panel();
            this.entriesListBox = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.openEntryBtn = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.entriesListBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            // 
            // entriesListBox
            // 
            this.entriesListBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.entriesListBox.FormattingEnabled = true;
            this.entriesListBox.ItemHeight = 20;
            this.entriesListBox.Location = new System.Drawing.Point(0, 46);
            this.entriesListBox.Name = "entriesListBox";
            this.entriesListBox.Size = new System.Drawing.Size(800, 404);
            this.entriesListBox.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openEntryBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // openEntryBtn
            // 
            this.openEntryBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.openEntryBtn.Image = ((System.Drawing.Image)(resources.GetObject("openEntryBtn.Image")));
            this.openEntryBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openEntryBtn.Name = "openEntryBtn";
            this.openEntryBtn.Size = new System.Drawing.Size(80, 24);
            this.openEntryBtn.Text = "openEntry";
            this.openEntryBtn.Click += new System.EventHandler(this.openEntryBtn_Click);
            // 
            // BMGEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "BMGEditForm";
            this.Text = "BMGEditForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BMGEditForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox entriesListBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton openEntryBtn;
    }
}