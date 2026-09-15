using System;
using System.Collections.Generic;
using System.Text;

namespace Pertemuan3
{
    internal class LatihanBerkelompok
    {
        // M Zambrotta A / 15
        // M Jalaluddin R / 19
        static void Siswa(string nama, string kelas, int usia, char jk)
        {
            Console.WriteLine("Nama saya: " + nama + "Usia Saya " + usia + "tahun" + "Dari kelas:" + kelas + "Berjenis kelamin: " + jk);
        }

        static void Sekolah(string namasekolah, string lokasi)
        {
            Console.WriteLine("Kita Berasal Dari " + namasekolah + " " + lokasi);
            Console.WriteLine();
        }
        static void TampilkanJurusan()
        {
            Console.WriteLine("Jurusan IT Di SMKN 6 Malang :  ");

            string[] jurusan = { "TKJ", "SIJA", "RPL" };
            foreach (string item in jurusan)
            {
                Console.WriteLine(item);
            }
        }

        static void Main()
        {
            Siswa("Alvin ", " XI RPL 1 ", 16, 'L');
            Siswa("Udin ", " XI RPL 1 ", 17, 'L');

            Sekolah("SMKN 6", "Malang");
            TampilkanJurusan();
        }
    }
}