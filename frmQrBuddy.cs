using Net.Codecrete.QrCodeGenerator;
using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
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
            //var bitmap = qr.ToBitmap(scale: 10, border: 1);
            var bitmap = qr.ToBmpBitmap(scale: 10, border: 1);

            using var ms = new MemoryStream(bitmap);
            using var tempImage = Image.FromStream(ms);
            QrPicture.Image = new Bitmap(tempImage); // Clone the image
        }

        private void QrPicture_Click(object sender, EventArgs e)
        {
            if (QrPicture.Image != null)
            {
                Clipboard.SetImage(QrPicture.Image);
                InfoLabel.Text = "QR image copied to clipboard.";
            }
            else
            {
                InfoLabel.Text = "No QR image to copy.";
            }
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

        private void SaveAs_Click(object sender, EventArgs e)
        {
            // Open a SaveFileDialog to save the QR code image
            using var saveFileDialog = new SaveFileDialog
            {
                Filter = "PNG Image|*.png",
                Title = "Save QR Code Image"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using var bitmap = QrPicture.Image;
                bitmap.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                InfoLabel.Text = "QR code saved successfully.";
            }
        }
    }
}
