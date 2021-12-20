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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewEntryForm));
            this.createEntryBtn = new System.Windows.Forms.Button();
            this.newEntryNameTxtBox = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // createEntryBtn
            // 
            this.createEntryBtn.Location = new System.Drawing.Point(169, 42);
            this.createEntryBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createEntryBtn.Name = "createEntryBtn";
            this.createEntryBtn.Size = new System.Drawing.Size(82, 22);
            this.createEntryBtn.TabIndex = 0;
            this.createEntryBtn.Text = "Create";
            this.createEntryBtn.UseVisualStyleBackColor = true;
            this.createEntryBtn.Click += new System.EventHandler(this.createEntryBtn_Click);
            // 
            // newEntryNameTxtBox
            // 
            this.newEntryNameTxtBox.Location = new System.Drawing.Point(5, 20);
            this.newEntryNameTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newEntryNameTxtBox.Name = "newEntryNameTxtBox";
            this.newEntryNameTxtBox.Size = new System.Drawing.Size(110, 23);
            this.newEntryNameTxtBox.TabIndex = 1;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.newEntryNameTxtBox);
            this.groupBox.Location = new System.Drawing.Point(10, 9);
            this.groupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox.Size = new System.Drawing.Size(147, 56);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Entry name";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(169, 16);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(82, 22);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // NewEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 83);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.createEntryBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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