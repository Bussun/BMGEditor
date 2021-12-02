namespace BMGEditor.UI
{
    partial class NewEntryForm
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
            this.createEntryBtn = new System.Windows.Forms.Button();
            this.newEntryNameTxtBox = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // createEntryBtn
            // 
            this.createEntryBtn.Location = new System.Drawing.Point(193, 56);
            this.createEntryBtn.Name = "createEntryBtn";
            this.createEntryBtn.Size = new System.Drawing.Size(94, 29);
            this.createEntryBtn.TabIndex = 0;
            this.createEntryBtn.Text = "Create";
            this.createEntryBtn.UseVisualStyleBackColor = true;
            this.createEntryBtn.Click += new System.EventHandler(this.createEntryBtn_Click);
            // 
            // newEntryNameTxtBox
            // 
            this.newEntryNameTxtBox.Location = new System.Drawing.Point(6, 26);
            this.newEntryNameTxtBox.Name = "newEntryNameTxtBox";
            this.newEntryNameTxtBox.Size = new System.Drawing.Size(125, 27);
            this.newEntryNameTxtBox.TabIndex = 1;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.newEntryNameTxtBox);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(168, 74);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Entry name";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(193, 21);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(94, 29);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // NewEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 111);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.createEntryBtn);
            this.Name = "NewEntryForm";
            this.Text = "NewEntryForm";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createEntryBtn;
        private System.Windows.Forms.TextBox newEntryNameTxtBox;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button cancelBtn;
    }
}