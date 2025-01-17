﻿namespace WinDynamicDesktop
{
    partial class DownloadDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.fileSizeProgressLabel = new System.Windows.Forms.Label();
            this.fileTransferSpeedLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Downloading images, please wait...";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(14, 42);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(250, 13);
            this.progressBar1.TabIndex = 0;
            // 
            // fileSizeProgressLabel
            // 
            this.fileSizeProgressLabel.AutoSize = true;
            this.fileSizeProgressLabel.Location = new System.Drawing.Point(12, 67);
            this.fileSizeProgressLabel.Name = "fileSizeProgressLabel";
            this.fileSizeProgressLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fileSizeProgressLabel.Size = new System.Drawing.Size(72, 13);
            this.fileSizeProgressLabel.TabIndex = 3;
            this.fileSizeProgressLabel.Text = "0 MB of 0 MB";
            // 
            // fileTransferSpeedLabel
            // 
            this.fileTransferSpeedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileTransferSpeedLabel.AutoSize = true;
            this.fileTransferSpeedLabel.Location = new System.Drawing.Point(217, 67);
            this.fileTransferSpeedLabel.Name = "fileTransferSpeedLabel";
            this.fileTransferSpeedLabel.Size = new System.Drawing.Size(42, 13);
            this.fileTransferSpeedLabel.TabIndex = 4;
            this.fileTransferSpeedLabel.Text = "0 MB/s";
            this.fileTransferSpeedLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(184, 83);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // DownloadDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(284, 118);
            this.ControlBox = false;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.fileTransferSpeedLabel);
            this.Controls.Add(this.fileSizeProgressLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::WinDynamicDesktop.Properties.Resources.AppIcon;
            this.Name = "DownloadDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinDynamicDesktop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label fileSizeProgressLabel;
        private System.Windows.Forms.Label fileTransferSpeedLabel;
        private System.Windows.Forms.Button cancelButton;
    }
}