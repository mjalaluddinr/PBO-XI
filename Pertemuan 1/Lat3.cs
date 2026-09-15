using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pertemuan_1
{
    internal class Lat3
    {
      static void Main()
        {
            Console.Write("Nama: ");
            string nama = Console.ReadLine();

            Console.Write("Usia: ");
            int usia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Halo " + nama + ", usia kamu " + usia);
        }
    }
}
