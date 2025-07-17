namespace GenQR
{
    partial class frmQrBuddy
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SourceText = new System.Windows.Forms.TextBox();
            Regenerate = new System.Windows.Forms.Button();
            QrPicture = new System.Windows.Forms.PictureBox();
            InfoLabel = new System.Windows.Forms.TextBox();
            SaveAs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)QrPicture).BeginInit();
            SuspendLayout();
            // 
            // SourceText
            // 
            SourceText.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            SourceText.Location = new System.Drawing.Point(30, 391);
            SourceText.Margin = new System.Windows.Forms.Padding(6);
            SourceText.Name = "SourceText";
            SourceText.Size = new System.Drawing.Size(411, 39);
            SourceText.TabIndex = 1;
            SourceText.TextChanged += SourceText_TextChanged;
            // 
            // Regenerate
            // 
            Regenerate.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            Regenerate.Location = new System.Drawing.Point(30, 453);
            Regenerate.Margin = new System.Windows.Forms.Padding(6);
            Regenerate.Name = "Regenerate";
            Regenerate.Size = new System.Drawing.Size(414, 49);
            Regenerate.TabIndex = 2;
            Regenerate.Text = "Regenerate";
            Regenerate.UseVisualStyleBackColor = true;
            Regenerate.Click += Regenerate_Click;
            // 
            // QrPicture
            // 
            QrPicture.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            QrPicture.Location = new System.Drawing.Point(30, 19);
            QrPicture.Margin = new System.Windows.Forms.Padding(6);
            QrPicture.Name = "QrPicture";
            QrPicture.Size = new System.Drawing.Size(414, 301);
            QrPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            QrPicture.TabIndex = 3;
            QrPicture.TabStop = false;
            QrPicture.Click += QrPicture_Click;
            // 
            // InfoLabel
            // 
            InfoLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            InfoLabel.BackColor = System.Drawing.SystemColors.Control;
            InfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            InfoLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            InfoLabel.Location = new System.Drawing.Point(30, 344);
            InfoLabel.Margin = new System.Windows.Forms.Padding(6);
            InfoLabel.Name = "InfoLabel";
            InfoLabel.Size = new System.Drawing.Size(414, 32);
            InfoLabel.TabIndex = 4;
            InfoLabel.Text = ":)";
            // 
            // SaveAs
            // 
            SaveAs.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            SaveAs.Location = new System.Drawing.Point(30, 525);
            SaveAs.Margin = new System.Windows.Forms.Padding(6);
            SaveAs.Name = "SaveAs";
            SaveAs.Size = new System.Drawing.Size(414, 49);
            SaveAs.TabIndex = 5;
            SaveAs.Text = "&Save As";
            SaveAs.UseVisualStyleBackColor = true;
            SaveAs.Click += SaveAs_Click;
            // 
            // frmQrBuddy
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(477, 612);
            Controls.Add(SaveAs);
            Controls.Add(InfoLabel);
            Controls.Add(QrPicture);
            Controls.Add(Regenerate);
            Controls.Add(SourceText);
            Margin = new System.Windows.Forms.Padding(6);
            Name = "frmQrBuddy";
            Text = "QR Buddy";
            Load += QrBuddy_Load;
            ((System.ComponentModel.ISupportInitialize)QrPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SourceText;
        private System.Windows.Forms.Button Regenerate;
        private System.Windows.Forms.PictureBox QrPicture;
        private System.Windows.Forms.TextBox InfoLabel;
        private System.Windows.Forms.Button SaveAs;
    }
}

