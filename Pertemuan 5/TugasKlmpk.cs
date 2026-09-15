// Anggota Kelompok:
//1. Mochamad Zambrotta Alvia / 15
//2. Muhammad Jalaluddin Rahmat / 19
//3. Muhammad Nouvall Rhaevdi Addakil / 20
using System; // Library dasar untuk menjalankan program console
using System.Globalization; // Library untuk menggunakan format angka Indonesia

namespace Pertemuan_5 // Namespace untuk mengelompokkan class pada program Pertemuan 5
{
    internal class TugasKlmpk // Class internal program
    {
        static void Main(string[] args) // Method utama yang pertamakali dijalankan
        {
            const int DISKON_MEMBER = 10; // Menetapkan diskon member sebesar 10%

            Menu[] daftarMenu = // Array untuk menyimpan seluruh objek menu
            {
                new MenuWarkop("Indomie Polos All Varian", 8000), // Membuat objek menu Indomie Polos
                new MenuWarkop("Indomie Telur + Sayur", 12000), // Membuat objek menu Indomie Telur
                new MenuWarkop("Kopi Hitam", 4000), // Membuat objek menu Kopi Hitam
                new MenuWarkop("Kopi Susu", 5000), // Membuat objek menu Kopi Susu
                new MenuWarkop("Teh Manis", 4000), // Membuat objek menu Teh Manis
                new MenuWarkop("Nutrisari", 5000), // Membuat objek menu Nutrisari
                new MenuWarkop("Extra Joss Susu", 7000), // Membuat objek menu Extra Joss Susu
                new MenuWarkop("Susu Jahe", 6000), // Membuat objek menu Susu Jahe
                new MenuWarkop("Roti Bakar", 10000), // Membuat objek menu Roti Bakar
                new MenuWarkop("Gorengan Per Pcs", 1000) // Membuat objek menu Gorengan
            };

            Menu[] pesanan = new Menu[10]; // Array untuk menyimpan maksimal 10 jenis pesanan
            int[] jumlah = new int[10]; // Array untuk menyimpan jumlah dari setiap pesanan

            int totalPesanan = 0; // Menghitung jumlah jenis menu yang dipesan
            bool member = false; // Menyimpan status member pembeli
            bool tambahMenu = true; // Mengatur proses penambahan menu

            // Menampilakan judul program KASI WARKOP
            Console.WriteLine("========================================");
            Console.WriteLine("             KASIR WARKOP");
            Console.WriteLine("========================================");

            Console.Write("Nama Pembeli        : "); // Meminta pembeli memasukkan nama
            string namaPembeli = Console.ReadLine(); // Menyimpan nama pembeli yang sudah di masukkan dari keyboard dan di simpan pada variabel namapembeli

            while (true) // Mengulang sampai pilihan member sesuai
            {
                Console.Write("Apakah Member? (Y/T): "); // Meminta status member pembeli
                string pilihan = Console.ReadLine().ToUpper(); // Menyimpan dan mengubah input menjadi huruf kapital

                if (pilihan == "Y") // Kondisi jika status pembeli merupakan member
                {
                    member = true; // Menetapkan status sebagai member
                    break; // Keluar dari perulangan
                }
                else if (pilihan == "T") // Kondisi jika status pembeli bukan member
                {
                    member = false; // Menetapkan status bukan member
                    break; // Keluar dari perulangan
                }
                else // Dijalankan jika input bukan Y atau T
                {
                    Console.WriteLine("Input harus Y atau T."); // Menampilkan pesan kesalahan karena memasukkan salain Y & T
                    continue; // Mengulang input status member sampai memasukkan Y atau T
                }
            }

            Console.WriteLine(); // Memberikan jarak antara data pembeli dengan daftar menu
            Console.WriteLine("============== DAFTAR MENU =============="); // Menampilkan judul daftar menu

            for (int i = 0; i < daftarMenu.Length; i++) // Mengulang seluruh daftar menu yang tersedia
            {
                Console.Write((i + 1) + ". "); // Menampilkan nomor urut menu
                daftarMenu[i].TampilkanMenu(); // Memanggil method TampilkanMenu untuk menampilkan nama dan harga
            }

            Console.WriteLine("========================================"); // Memberikan batas akhir daftar menu

            while (tambahMenu && totalPesanan < pesanan.Length) // Mengulang proses pemesanan selama masih ingin menambah menu
            {
                try // Mencoba menjalankan proses input pesanan
                {
                    Console.WriteLine(); // Memberikan jarak sebelum memasukkan pesanan

                    Console.Write("Pilih Menu : "); // Meminta pembeli memasukkan nomor menu
                    int pilihanMenu = Convert.ToInt32(Console.ReadLine()); // Menyimpan dan mengubah input pilihan menu menjadi integer

                    if (pilihanMenu < 1 || pilihanMenu > daftarMenu.Length) // Mengecek apakah nomor menu tersedia
                    {
                        Console.WriteLine("Menu tidak tersedia."); // Menampilkan pesan jika nomor menu tidak tersedia
                        continue; // Mengulang input pilihan menu
                    }

                    Console.Write("Jumlah     : "); // Meminta pembeli memasukkan jumlah pesanan
                    int jumlahBeli = Convert.ToInt32(Console.ReadLine()); // Menyimpan dan mengubah input jumlah menjadi integer

                    if (jumlahBeli <= 0) // Mengecek apakah jumlah pesanan lebih dari 0
                    {
                        Console.WriteLine("Jumlah harus lebih dari 0."); // Menampilkan pesan jika jumlah tidak sesuai
                        continue; // Mengulang proses pemesanan
                    }

                    pesanan[totalPesanan] = daftarMenu[pilihanMenu - 1]; // Menyimpan menu yang dipilih ke dalam array pesanan
                    jumlah[totalPesanan] = jumlahBeli; // Menyimpan jumlah pembelian sesuai dengan pesanan
                    totalPesanan++; // Menambah jumlah data pesanan

                    Console.WriteLine("Menu berhasil ditambahkan."); // Menampilkan pesan menu berhasil ditambahkan
                    Console.WriteLine(); // Memberikan jarak sebelum pilihan menambahkan menu

                    if (totalPesanan == pesanan.Length) // Mengecek apakah array pesanan sudah penuh
                    {
                        Console.WriteLine("Pesanan sudah mencapai batas maksimal."); // Menampilkan pesan batas maksimal pesanan
                        break; // Menghentikan proses pemesanan
                    }

                    while (true) // Mengulang sampai input tambah menu sesuai
                    {
                        Console.Write("Tambah Menu? (Y/T) : "); // Meminta pilihan untuk menambah menu
                        string pilihanTambah = Console.ReadLine().ToUpper(); // Menyimpan dan mengubah input menjadi huruf kapital

                        if (pilihanTambah == "Y") // Kondisi jika pembeli ingin menambah menu
                        {
                            break; // Kembali ke proses pemilihan menu
                        }
                        else if (pilihanTambah == "T") // Kondisi jika pembeli tidak ingin menambah menu
                        {
                            tambahMenu = false; // Mengubah tambahMenu menjadi false agar proses pemesanan berhenti
                            break; // Keluar dari perulangan
                        }
                        else // Dijalankan jika input bukan Y atau T
                        {
                            Console.WriteLine("Input harus Y atau T."); // Menampilkan pesan kesalahan karena memasukkan selain Y & T
                            continue; // Mengulang input sampai memasukkan Y atau T
                        }
                    }
                }
                catch (FormatException) // Menangani kesalahan jika input bukan berupa angka
                {
                    Console.WriteLine("Input harus berupa angka."); // Menampilkan pesan kesalahan format input
                    continue; // Mengulang proses input pesanan
                }
                catch (OverflowException) // Menangani kesalahan jika angka yang dimasukkan terlalu besar
                {
                    Console.WriteLine("Angka yang dimasukkan terlalu besar."); // Menampilkan pesan angka melebihi batas
                    continue; // Mengulang proses input pesanan
                }
            }

            KasirWarkop kasir = new KasirWarkop(); // Membuat objek kasir dari class KasirWarkop

            double totalBelanja = kasir.HitungTotal(pesanan, jumlah, totalPesanan); // Menyimpan hasil perhitungan seluruh pesanan
            double diskon = 0; // Menetapkan nilai awal diskon menjadi 0

            if (member) // Mengecek apakah pembeli merupakan member
            {
                double persenDiskon = (double)DISKON_MEMBER / 100; // Casting DISKON_MEMBER dari int menjadi double
                diskon = Math.Round(totalBelanja * persenDiskon); // Menghitung jumlah diskon yang didapat member
            }

            double totalBayar = totalBelanja - diskon; // Menghitung total yang harus dibayar setelah dikurangi diskon
            double uangBayar = 0; // Menetapkan nilai awal uang pembayaran menjadi 0

            Console.WriteLine(); // Memberikan jarak sebelum bagian pembayaran
            Console.WriteLine("========================================"); // Memberikan batas awal bagian pembayaran
            Console.WriteLine("Total Bayar : Rp" + kasir.FormatRupiah(totalBayar)); // Menampilkan total yang harus dibayar
            Console.WriteLine("========================================"); // Memberikan batas akhir total pembayaran

            while (true) // Mengulang sampai uang pembayaran mencukupi
            {
                try // Mencoba menjalankan proses input pembayaran
                {
                    Console.Write("Uang Bayar  : Rp"); // Meminta pembeli memasukkan jumlah uang pembayaran
                    uangBayar = Convert.ToDouble(Console.ReadLine()); // Menyimpan dan mengubah input pembayaran menjadi double

                    if (uangBayar < totalBayar) // Mengecek apakah uang pembayaran kurang
                    {
                        double kekurangan = totalBayar - uangBayar; // Menghitung jumlah uang yang masih kurang

                        Console.WriteLine("Uang pembayaran kurang Rp" + kasir.FormatRupiah(kekurangan)); // Menampilkan jumlah kekurangan pembayaran
                        continue; // Mengulang input uang pembayaran
                    }

                    break; // Keluar dari perulangan jika pembayaran sudah cukup
                }
                catch (FormatException) // Menangani kesalahan jika input pembayaran bukan angka
                {
                    Console.WriteLine("Input harus berupa angka."); // Menampilkan pesan kesalahan format input
                    continue; // Mengulang input pembayaran
                }
                catch (OverflowException) // Menangani kesalahan jika angka pembayaran terlalu besar
                {
                    Console.WriteLine("Angka yang dimasukkan terlalu besar."); // Menampilkan pesan angka melebihi batas
                    continue; // Mengulang input pembayaran
                }
            }

            double kembalian = uangBayar - totalBayar; // Menghitung uang kembalian pembeli

            kasir.CetakStruk(namaPembeli, member, pesanan, jumlah, totalPesanan, totalBelanja, diskon, totalBayar, uangBayar, kembalian); // Memanggil method CetakStruk untuk mencetak hasil transaksi
        }
    }

    abstract class Menu // Class abstract sebagai induk dari MenuWarkop
    {
        private string nama; // Variabel private untuk menyimpan nama menu
        private double harga; // Variabel private untuk menyimpan harga menu

        public string Nama // Property untuk mengakses variabel nama
        {
            get { return nama; } // Mengambil nilai nama
            set { nama = value; } // Menyimpan nilai ke variabel nama
        }

        public double Harga // Property untuk mengakses variabel harga
        {
            get { return harga; } // Mengambil nilai harga

            set // Mengatur nilai harga
            {
                if (value >= 0) // Mengecek agar harga tidak bernilai negatif
                {
                    harga = value; // Menyimpan nilai harga jika sesuai
                }
            }
        }

        public Menu(string nama, double harga) // Constructor untuk menerima nama dan harga menu
        {
            Nama = nama; // Menyimpan parameter nama ke property Nama
            Harga = harga; // Menyimpan parameter harga ke property Harga
        }

        public abstract void TampilkanMenu(); // Method abstract yang wajib dibuat pada class turunannya
    }

    class MenuWarkop : Menu // Class MenuWarkop yang mewarisi class Menu
    {
        public MenuWarkop(string nama, double harga) : base(nama, harga) // Mengirim nama dan harga ke constructor class Menu
        {
        }

        public override void TampilkanMenu() // Method override dari method abstract TampilkanMenu
        {
            string hargaMenu = Harga.ToString("N0", new CultureInfo("id-ID")); // Mengubah harga ke format angka Indonesia

            Console.WriteLine(Nama + " - Rp" + hargaMenu); // Menampilkan nama menu dan harganya
        }
    }

    interface IPencetakStruk // Interface yang berisi method untuk mencetak struk
    {
        void CetakStruk(string namaPembeli, bool member, Menu[] pesanan, int[] jumlah, int totalPesanan, double totalBelanja, double diskon, double totalBayar, double uangBayar, double kembalian); // Method yang harus dibuat oleh class yang menggunakan interface
    }

    class KasirWarkop : IPencetakStruk // Class KasirWarkop yang menggunakan interface IPencetakStruk
    {
        public double HitungTotal(Menu[] pesanan, int[] jumlah, int totalPesanan) // Method untuk menghitung total seluruh pesanan
        {
            double total = 0; // Menetapkan nilai awal total menjadi 0

            for (int i = 0; i < totalPesanan; i++) // Mengulang perhitungan seluruh pesanan
            {
                total += pesanan[i].Harga * jumlah[i]; // Menjumlahkan harga menu dikali jumlah pembelian
            }

            return total; // Mengembalikan hasil total belanja
        }

        public string FormatRupiah(double nilai) // Method untuk mengubah angka menjadi format rupiah
        {
            return Math.Round(nilai).ToString("N0", new CultureInfo("id-ID")); // Membulatkan nilai dan memberi pemisah ribuan
        }

        public void CetakStruk(string namaPembeli, bool member, Menu[] pesanan, int[] jumlah, int totalPesanan, double totalBelanja, double diskon, double totalBayar, double uangBayar, double kembalian) // Method untuk mencetak struk transaksi
        {
            Console.WriteLine(); // Memberikan jarak sebelum struk dicetak
            Console.WriteLine("=============== STRUK ==============="); // Menampilkan judul struk
            Console.WriteLine("Nama Pembeli : " + namaPembeli); // Menampilkan nama pembeli
            Console.WriteLine("Member       : " + (member ? "Ya" : "Tidak")); // Menampilkan status member
            Console.WriteLine("-------------------------------------"); // Memberikan batas antara data pembeli dan pesanan

            for (int i = 0; i < totalPesanan; i++) // Mengulang seluruh pesanan yang sudah dibeli
            {
                double subtotal = pesanan[i].Harga * jumlah[i]; // Menghitung subtotal dari setiap pesanan

                Console.WriteLine(pesanan[i].Nama + " x" + jumlah[i] + " = Rp" + FormatRupiah(subtotal)); // Menampilkan nama, jumlah, dan subtotal pesanan
            }

            Console.WriteLine("-------------------------------------"); // Memberikan batas antara pesanan dan total pembayaran
            Console.WriteLine("Total Belanja : Rp" + FormatRupiah(totalBelanja)); // Menampilkan total belanja
            Console.WriteLine("Diskon        : Rp" + FormatRupiah(diskon)); // Menampilkan jumlah diskon
            Console.WriteLine("Total Bayar   : Rp" + FormatRupiah(totalBayar)); // Menampilkan total pembayaran
            Console.WriteLine("Uang Bayar    : Rp" + FormatRupiah(uangBayar)); // Menampilkan uang yang dibayarkan
            Console.WriteLine("Kembalian     : Rp" + FormatRupiah(kembalian)); // Menampilkan uang kembalian
            Console.WriteLine("====================================="); // Memberikan batas akhir rincian pembayaran
            Console.WriteLine("             TERIMA KASIH"); // Menampilkan ucapan terima kasih
            Console.WriteLine("====================================="); // Menutup tampilan struk
        }
    }
}