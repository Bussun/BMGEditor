using System;
using System.Collections;
using System.Windows.Forms;

namespace BMGEditor
{
    partial class MainForm
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
            this.openFileBtn = new System.Windows.Forms.Button();
            this.closeFileBtn = new System.Windows.Forms.Button();
            this.openTextEditorBtn = new System.Windows.Forms.Button();
            this.openBcsvEditorBtn = new System.Windows.Forms.Button();
            this.openARCFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileBtn
            // 
            this.openFileBtn.Location = new System.Drawing.Point(12, 12);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(94, 29);
            this.openFileBtn.TabIndex = 0;
            this.openFileBtn.Text = "Open file";
            this.openFileBtn.UseVisualStyleBackColor = true;
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // closeFileBtn
            // 
            this.closeFileBtn.Enabled = false;
            this.closeFileBtn.Location = new System.Drawing.Point(220, 12);
            this.closeFileBtn.Name = "closeFileBtn";
            this.closeFileBtn.Size = new System.Drawing.Size(94, 29);
            this.closeFileBtn.TabIndex = 1;
            this.closeFileBtn.Text = "Close file";
            this.closeFileBtn.UseVisualStyleBackColor = true;
            this.closeFileBtn.Click += new System.EventHandler(this.closeFileBtn_Click);
            // 
            // openTextEditorBtn
            // 
            this.openTextEditorBtn.Enabled = false;
            this.openTextEditorBtn.Location = new System.Drawing.Point(12, 60);
            this.openTextEditorBtn.Name = "openTextEditorBtn";
            this.openTextEditorBtn.Size = new System.Drawing.Size(94, 29);
            this.openTextEditorBtn.TabIndex = 2;
            this.openTextEditorBtn.Text = "Text edit";
            this.openTextEditorBtn.UseVisualStyleBackColor = true;
            this.openTextEditorBtn.Click += new System.EventHandler(this.openTextEditorBtn_Click);
            // 
            // openBcsvEditorBtn
            // 
            this.openBcsvEditorBtn.Enabled = false;
            this.openBcsvEditorBtn.Location = new System.Drawing.Point(220, 60);
            this.openBcsvEditorBtn.Name = "openBcsvEditorBtn";
            this.openBcsvEditorBtn.Size = new System.Drawing.Size(94, 29);
            this.openBcsvEditorBtn.TabIndex = 3;
            this.openBcsvEditorBtn.Text = "Entries editor";
            this.openBcsvEditorBtn.UseVisualStyleBackColor = true;
            this.openBcsvEditorBtn.Click += new System.EventHandler(this.openBcsvEditorBtn_Click);
            // 
            // openARCFileDialog
            // 
            this.openARCFileDialog.FileName = "Message.arc";
            this.openARCFileDialog.Filter = "Nintendo archive files|*.arc";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 101);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.openBcsvEditorBtn);
            this.Controls.Add(this.openTextEditorBtn);
            this.Controls.Add(this.closeFileBtn);
            this.Controls.Add(this.openFileBtn);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button openFileBtn;
        private Button closeFileBtn;
        private Button openTextEditorBtn;
        private Button openBcsvEditorBtn;
        private OpenFileDialog openARCFileDialog;
        private Button button1;
    }
}