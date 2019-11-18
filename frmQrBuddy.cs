using Net.Codecrete.QrCodeGenerator;
using System;
using System.Windows.Forms;

namespace GenQR
{
    public partial class frmQrBuddy : Form
    {
        public frmQrBuddy()
        {
            InitializeComponent();
        }

        private void Regenerate_Click(object sender, EventArgs e)
        {
            RegenerateQr();
            InfoLabel.Text = "QR generated from text.";
        }

        private void ClearInfoLabel()
        {
            InfoLabel.Text = "";
        }

        private void SourceText_TextChanged(object sender, EventArgs e)
        {
            RegenerateQr();
            ClearInfoLabel();
        }

        private void RegenerateQr()
        {
            var qr = QrCode.EncodeText(SourceText.Text, QrCode.Ecc.Medium);
            var bitmap = qr.ToBitmap(scale: 10, border: 1);

            //bitmap.Save("qr-code.png", ImageFormat.Png);
            QrPicture.Image = bitmap;
        }

        private void QrPicture_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(QrPicture.Image);
            InfoLabel.Text = "QR image copied to clipboard.";
        }

        private void QrBuddy_Load(object sender, EventArgs e)
        {
            var clipText = Clipboard.GetText();
            if (clipText?.Length < 100)
            {
                SourceText.Text = clipText;
                InfoLabel.Text = "QR generated from clipboard.";
                RegenerateQr();
            }
        }
    }
}
