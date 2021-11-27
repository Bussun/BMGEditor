namespace BMGEditor
{
    partial class BcsvEditorForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BcsvEditorForm));
            this.tsToolbar = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.dgvBcsv = new System.Windows.Forms.DataGridView();
            this.tsToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBcsv)).BeginInit();
            this.SuspendLayout();
            // 
            // tsToolbar
            // 
            this.tsToolbar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave});
            this.tsToolbar.Location = new System.Drawing.Point(0, 0);
            this.tsToolbar.Name = "tsToolbar";
            this.tsToolbar.Size = new System.Drawing.Size(1039, 27);
            this.tsToolbar.TabIndex = 0;
            this.tsToolbar.Text = "toolStrip1";
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSave.Enabled = false;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(44, 24);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvBcsv
            // 
            this.dgvBcsv.AllowUserToResizeRows = false;
            this.dgvBcsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBcsv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBcsv.Location = new System.Drawing.Point(0, 27);
            this.dgvBcsv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvBcsv.MultiSelect = false;
            this.dgvBcsv.Name = "dgvBcsv";
            this.dgvBcsv.RowHeadersWidth = 51;
            this.dgvBcsv.Size = new System.Drawing.Size(1039, 731);
            this.dgvBcsv.TabIndex = 1;
            // 
            // BcsvEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 758);
            this.Controls.Add(this.dgvBcsv);
            this.Controls.Add(this.tsToolbar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BcsvEditorForm";
            this.Text = "[DEBUG] BCSV editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BcsvEditorForm_FormClosing);
            this.tsToolbar.ResumeLayout(false);
            this.tsToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBcsv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsToolbar;
        private System.Windows.Forms.DataGridView dgvBcsv;
        private System.Windows.Forms.ToolStripButton btnSave;
    }
}