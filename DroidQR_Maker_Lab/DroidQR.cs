using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QRCoder;
using System.Drawing;
using System.IO;

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
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qRCodeData = qrGenerator.CreateQrCode(DroidID, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qRCodeData);

            Bitmap qrCodeImage = qrCode.GetGraphic(20);

            string folderpath = Path.Combine(Directory.GetCurrentDirectory(), "QR_Codes");
            Directory.CreateDirectory(folderpath);

            string fileName = $"Droid_{DroidID}_QR.png";
            string filePath = Path.Combine(folderpath, fileName);

            qrCodeImage.Save(filePath);
            Console.WriteLine($"QR Code for droid {DroidID} saved to {filePath}");
        }
    }
}
