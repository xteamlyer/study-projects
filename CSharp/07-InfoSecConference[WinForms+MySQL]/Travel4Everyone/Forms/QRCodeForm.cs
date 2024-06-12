using QRCoder;
using System.Drawing;
using System.Windows.Forms;

namespace Forms
{
    public partial class QRCodeForm : Form
    {
        public QRCodeForm(string url)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            // Создание экземпляра QRCodeGenerator
            QRCodeGenerator qrGenerator = new QRCodeGenerator();

            // Создание QR-кода
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(url, QRCodeGenerator.ECCLevel.Q);

            // Создание QR-кода из QR-кода
            QRCode qrCode = new QRCode(qrCodeData);

            // Получение изображения QR-кода
            Bitmap qrCodeImage = qrCode.GetGraphic(6); // 20 - размер пикселя

            // Отображение изображения в PictureBox
            pictureBoxQRCode.Image = qrCodeImage;
        }
    }
}
