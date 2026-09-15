using System;
using System.Collections.Generic;
using System.Text;

namespace Pertemuan_2
{
    internal class Tgs
    {
        static void Main()
        {
            // komponen nilai untuk pembagi rata-rata
            const double JUMLAH_NILAI = 2.0;

            // Meminta input nama dari keyboard
            Console.Write("Masukkan Nama       : ");

            // Mengambil input nama dan menyimpannya ke dalam variabel string
            string nama = Console.ReadLine();

            // Meminta input nilai tugas dari keyboard
            Console.Write("Masukkan Nilai Tugas: ");

            // Mengambil nilaiTugas dan mengonversi inputan string ke tipe data double
            double nilaiTugas = Convert.ToDouble(Console.ReadLine());

            // Meminta input nilai ujian dari keyboard
            Console.Write("Masukkan Nilai Ujian: ");

            // Mengambil nilaiUjian dan mengonversi inputan string ke tipe data double
            double nilaiUjian = Convert.ToDouble(Console.ReadLine());

            // Menghitung rata-rata (Nilai Tugas + Nilai Ujian) dibagi 2
            double nilaiAkhir = (nilaiTugas + nilaiUjian) / JUMLAH_NILAI;

            Console.WriteLine(); // Memberikan jarak dari perhitungan nilai akhir dan output yang di tampilkan 
            Console.WriteLine("--- HASIL PENILAIAN ---"); // Menampilkan pesan HASIL PENILAIAN
            Console.WriteLine("Nama        : " + nama);       // Menampilkan nama yang telah diinputkan
            Console.WriteLine("Nilai Akhir : " + nilaiAkhir); // Menampilkan hasil perhitungan

            // Kondisi untuk mengecek kelulusan 
            if (nilaiAkhir >= 75)
            {
                // Menampilakan output "LULUS" jika nilaiAkhir >= 75
                Console.WriteLine("Status      : LULUS");
            }
            else
            {
                // Menampilakan output "TIDAK LULUS" jika nilaiAkhir di bawah 75
                Console.WriteLine("Status      : TIDAK LULUS");
            }
        }
    }
}