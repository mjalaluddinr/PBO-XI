using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pertemuan_1
{
    internal class Tgs2
    {
        static void Main() //kode program utama yang akan dijalankan pertama kali
        {
            Console.WriteLine("Program Menghitung Luas Persegi");

            // menampilkan pesan untuk meminta memasukkan nilai panjang sisi persegi
            Console.Write("Masukkan nilai panjang sisi persegi (dalam cm) : ");
            double sisi = Convert.ToDouble(Console.ReadLine()); // mengambil nilai panjang sisi dari keyboard dan mengkonversikan ke tipe data double

            double luas; // deklarasi variabel luas untuk menyimpan hasil luas persegi dari sisi yang diinputkan di keyboard

            luas = sisi * sisi; // rumus untuk menghitung luas persegi dari hasil sisi x sisi

            Console.WriteLine("Nilai panjang sisi persegi = " + sisi + " cm"); // menampilkan output nilai sisi yang sudah dimasukkan di keyboard menggunkan readline
            Console.WriteLine("Luas persegi = " + luas + " cm²"); // menampilkan output hasil luas persegi dari perhitungan sisi x sisi 
        }
    }
}
