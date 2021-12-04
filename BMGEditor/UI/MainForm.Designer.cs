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
            this.openTextEditorBtn = new System.Windows.Forms.Button();
            this.openARCFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.openTextEditorEmptyBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileBtn
            // 
            this.openFileBtn.Enabled = false;
            this.openFileBtn.Location = new System.Drawing.Point(98, 59);
            this.openFileBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(82, 22);
            this.openFileBtn.TabIndex = 0;
            this.openFileBtn.Text = "Open file";
            this.openFileBtn.UseVisualStyleBackColor = true;
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // openTextEditorBtn
            // 
            this.openTextEditorBtn.Enabled = false;
            this.openTextEditorBtn.Location = new System.Drawing.Point(12, 59);
            this.openTextEditorBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.openTextEditorBtn.Name = "openTextEditorBtn";
            this.openTextEditorBtn.Size = new System.Drawing.Size(82, 22);
            this.openTextEditorBtn.TabIndex = 2;
            this.openTextEditorBtn.Text = "Text edit";
            this.openTextEditorBtn.UseVisualStyleBackColor = true;
            this.openTextEditorBtn.Click += new System.EventHandler(this.openTextEditorBtn_Click);
            // 
            // openARCFileDialog
            // 
            this.openARCFileDialog.FileName = "Message.arc";
            this.openARCFileDialog.Filter = "Nintendo archive files|*.arc";
            // 
            // aboutBtn
            // 
            this.aboutBtn.Location = new System.Drawing.Point(167, 11);
            this.aboutBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(89, 22);
            this.aboutBtn.TabIndex = 4;
            this.aboutBtn.Text = "About";
            this.aboutBtn.UseVisualStyleBackColor = true;
            this.aboutBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // openTextEditorEmptyBtn
            // 
            this.openTextEditorEmptyBtn.Location = new System.Drawing.Point(10, 11);
            this.openTextEditorEmptyBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.openTextEditorEmptyBtn.Name = "openTextEditorEmptyBtn";
            this.openTextEditorEmptyBtn.Size = new System.Drawing.Size(151, 22);
            this.openTextEditorEmptyBtn.TabIndex = 5;
            this.openTextEditorEmptyBtn.Text = "Text edit [without ARC]";
            this.openTextEditorEmptyBtn.UseVisualStyleBackColor = true;
            this.openTextEditorEmptyBtn.Click += new System.EventHandler(this.openTextEditorEmptyBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "These buttons will be deleted";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 92);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openTextEditorEmptyBtn);
            this.Controls.Add(this.aboutBtn);
            this.Controls.Add(this.openTextEditorBtn);
            this.Controls.Add(this.openFileBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button openFileBtn;
        private Button openTextEditorBtn;
        private OpenFileDialog openARCFileDialog;
        private Button aboutBtn;
        private Button openTextEditorEmptyBtn;
        private Label label1;
    }
}