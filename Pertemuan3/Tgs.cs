using System;
using System.Collections.Generic;
using System.Text;

namespace Pertemuan3
{
    internal class Tgs
    {
        /// Method untuk mengambil input dari user dan menyimpannya ke dalam Array string
        static string[] InputDataSiswa()
        {
            // Deklarasi array string dengan 3 kapasitas
            string[] data = new string[3];

            // Meminta dan membaca input Nama
            Console.Write("Masukkan Nama       : ");
            data[0] = Console.ReadLine(); // Menyimpan nama ke indeks ke-0

            // Meminta dan membaca input Nilai Tugas (masih berupa string)
            Console.Write("Masukkan Nilai Tugas: ");
            data[1] = Console.ReadLine(); // Menyimpan nilai tugas ke indeks ke-1

            // Meminta dan membaca input Nilai Ujian (masih berupa string)
            Console.Write("Masukkan Nilai Ujian: ");
            data[2] = Console.ReadLine(); // Menyimpan nilai ujian ke indeks ke-2

            // Mengembalikan array yang berisi ketiga data tersebut
            return data;
        }

        /// Method untuk menghitung rata-rata nilai
        static double HitungNilaiAkhir(double tugas, double ujian)
        { // Deklarasi konstanta pembagi untuk menghitung rata-rata
         const double JUMLAH_NILAI = 2.0;

          // Menghitung rata-rata dengan menjumlahkan tugas dan ujian kemudian di bagi dengan jumlah nilai yang ada
         return (tugas + ujian) / JUMLAH_NILAI;
        }

        /// Method untuk menentukan status kelulusan berdasarkan nilai akhir
        static string CekStatusLulus(double nilaiAkhir)
        {
            // Mengecek apakah nilai akhir memenuhi atau melebihi batas kelulusan (75)
            if (nilaiAkhir >= 75)
            {
                return "LULUS"; // Mengembalikan status LULUS jika syarat terpenuhi
            }
            else
            {
                return "TIDAK LULUS"; // Mengembalikan status TIDAK LULUS jika nilai di bawah 75
            }
        }

        /// Method untuk menampilkan  hasil ke layar console
        static void TampilkanHasil(string nama, double nilaiAkhir)
        {
            // Memanggil fungsi eksternal untuk menentukan status kelulusan berdasarkan nilai akhir
            string status = CekStatusLulus(nilaiAkhir);

            Console.WriteLine(); // Memberi jarak 1 baris kosong agar tampilan lebih bersih
            Console.WriteLine("--- HASIL PENILAIAN ---");
            Console.WriteLine("Nama        : " + nama);       // Menampilkan nama siswa
            Console.WriteLine("Nilai Akhir : " + nilaiAkhir); // Menampilkan nilai akhir
            Console.WriteLine("Status      : " + status);     // Menampilkan status kelulusan (Lulus/Tidak Lulus)
        }

        // Method utama untuk menjalankan program
        static void Main()
        {
            // Array untuk menyimpan data input Nama, Nilai Tugas dan Nilai Ujian
            string[] dataSiswa = InputDataSiswa();

            // Mengonversi input nilai dari string (array) ke double
            double nilaiTugas = Convert.ToDouble(dataSiswa[1]);
            double nilaiUjian = Convert.ToDouble(dataSiswa[2]);

            // Method untuk menghitung nilai akhir
            double nilaiAkhir = HitungNilaiAkhir(nilaiTugas, nilaiUjian);

            // Method untuk menampilkan hasil penilaian
            TampilkanHasil(dataSiswa[0], nilaiAkhir);
        }
    }
}
