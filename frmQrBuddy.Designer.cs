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
            this.SourceText = new System.Windows.Forms.TextBox();
            this.Regenerate = new System.Windows.Forms.Button();
            this.QrPicture = new System.Windows.Forms.PictureBox();
            this.InfoLabel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.QrPicture)).BeginInit();
            // 
            // SourceText
            // 
            this.SourceText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SourceText.Location = new System.Drawing.Point(16, 276);
            this.SourceText.Name = "SourceText";
            this.SourceText.Size = new System.Drawing.Size(250, 23);
            this.SourceText.TabIndex = 1;
            this.SourceText.TextChanged += new System.EventHandler(this.SourceText_TextChanged);
            // 
            // Regenerate
            // 
            this.Regenerate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Regenerate.Location = new System.Drawing.Point(16, 305);
            this.Regenerate.Name = "Regenerate";
            this.Regenerate.Size = new System.Drawing.Size(250, 23);
            this.Regenerate.TabIndex = 2;
            this.Regenerate.Text = "Regenerate";
            this.Regenerate.UseVisualStyleBackColor = true;
            this.Regenerate.Click += new System.EventHandler(this.Regenerate_Click);
            // 
            // QrPicture
            // 
            this.QrPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QrPicture.Location = new System.Drawing.Point(16, 9);
            this.QrPicture.Name = "QrPicture";
            this.QrPicture.Size = new System.Drawing.Size(250, 224);
            this.QrPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.QrPicture.TabIndex = 3;
            this.QrPicture.TabStop = false;
            this.QrPicture.Click += new System.EventHandler(this.QrPicture_Click);
            // 
            // InfoLabel
            // 
            this.InfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoLabel.BackColor = System.Drawing.SystemColors.Control;
            this.InfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InfoLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.InfoLabel.Location = new System.Drawing.Point(16, 254);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(250, 16);
            this.InfoLabel.TabIndex = 4;
            this.InfoLabel.Text = ":)";
            // 
            // frmQrBuddy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 338);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.QrPicture);
            this.Controls.Add(this.Regenerate);
            this.Controls.Add(this.SourceText);
            this.Name = "frmQrBuddy";
            this.Text = "QR Buddy";
            this.Load += new System.EventHandler(this.QrBuddy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QrPicture)).EndInit();

        }

        #endregion
        private System.Windows.Forms.TextBox SourceText;
        private System.Windows.Forms.Button Regenerate;
        private System.Windows.Forms.PictureBox QrPicture;
        private System.Windows.Forms.TextBox InfoLabel;
    }
}

