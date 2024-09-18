using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine($"QR Code for Droid {DroidID} has been generated.");
        }
    }
}
