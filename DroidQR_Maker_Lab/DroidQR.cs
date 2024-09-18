using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QRCoder;
using System.IO;
using System.Drawing;


namespace DroidQR_Maker_Lab
{
    internal class DroidQR
    {
        public string DroidID { get; set; }

        public DroidQR(string droidID)
        {
            DroidID = droidID;
        }

        // Placeholder for students to implement the QR Code generation logic
        public void GenerateQRCode()
        {
            // TODO: Implement QR Code generation and saving functionality
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(DroidID, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);

            Bitmap qrCodeImage = qrCode.GetGraphic(20);

            string FolderPath = Path.Combine(Directory.GetCurrentDirectory(), "QR_Codes");

            string fileName = $"Droid_{DroidID}_QR.png";
            string filePath = Path.Combine(FolderPath, fileName);

            qrCodeImage.Save(filePath);

            Console.WriteLine($"QR Code for Droid {DroidID} has been generated.");
        }
    }
}
