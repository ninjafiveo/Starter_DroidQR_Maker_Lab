using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QRCoder;
using System.IO;
using System.Drawing;
using System.Windows.Media.Imaging;

namespace DroidQR_Maker_Lab
{
    internal class DroidQR
    {
        public string DroidID { get; set; }

        public DroidQR(string droidID)
        {
            DroidID = droidID;
        }

        public void GenerateQRCode()
        {
            // Create a QR generator
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(DroidID, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);

            // Convert qr code into bitmap img
            Bitmap qrCodeImage = qrCode.GetGraphic(20);

            // Save qr code as image file
            string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "QR_Codes");
            Directory.CreateDirectory(folderPath); // ensure folder exists

            string fileName = $"Droid_{DroidID}_QR.png";
            string filePath = Path.Combine(folderPath, fileName);

            qrCodeImage.Save(filePath);
            Console.WriteLine($"QR Code for Droid {DroidID} has been generated.");
        }
    }
}
