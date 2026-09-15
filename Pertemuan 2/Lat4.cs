using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Pertemuan_2
{
    internal class Lat4
    {
        public static void Main()
        {
            for (int i = 0; i < 3; i++)
            {
                string cuaca = Console.ReadLine();
                switch (cuaca)
                {
                    case "Hujan":
                        Console.WriteLine("Naik Mobil");
                        break;
                    case "Terang":
                        Console.WriteLine("Naik Sepeda");
                        break;
                    case "Macet":
                        Console.WriteLine("Jalan Kaki");
                        break;
                }
            }
        }
    }
}
