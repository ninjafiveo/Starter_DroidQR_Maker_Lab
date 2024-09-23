﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QRCoder;
using System.Drawing;
using System.OI;

namespace DroidQR_Maker_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;

            while (keepGoing)
            {
                // Prompt for Droid ID
                Console.WriteLine("Lord Palpatine demands a QR Code for a new Stormtrooper.");
                Console.Write("Enter the Stormtrooper's Droid ID: ");
                string droidID = Console.ReadLine();

                // Create QR Code (To be completed by students)
                DroidQR_Maker_Lab.DroidQR droidQR = new DroidQR_Maker_Lab.DroidQR(droidID);
                droidQR.GenerateQRCode();

                // Ask if they want to generate another QR Code
                Console.WriteLine("Would you like to generate another QR Code? (y/n)");
                string response = Console.ReadLine().ToLower();
                //added
                keepGoing = response == "y";
            }

            Console.WriteLine("Darth Vader has completed his clerk work for the day!");

        }
    }
}
