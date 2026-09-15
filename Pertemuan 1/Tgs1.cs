using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pertemuan_1
{
    internal class Tgs1
    {
        static void Main() // kode program utama yang akan dijalankan pertama kali
        {
            string nama_penjual = "udin"; //deklarasi variabel nama penjual
            string nama_buah = "semangka"; //deklarasi variabel nama buah
            int harga_per3 = 15000; //deklarasi variabel dari harga per 3 buah semangka
            string jenis_vitamin = "Vitamin A"; //deklarasi variabel jenis vitamin dari buah semangka
            double harga_satuan = 5.5555; //deklarasi variabel untuk harga satuan buah semangka

            //menampilkan output menggunakan ke lima variabel yang sudah dideklarasikan menggunakan Console.WriteLine
            Console.WriteLine("Saya membeli buah " + nama_buah + " dipasar,di toko pak " + nama_penjual + ",saya beli semangka 3 dengan harga " + harga_per3 + " ,karena harga 1 an nya " + harga_satuan + " saya beli semangka karena vitaminnya " + jenis_vitamin);
        }
    }
}
