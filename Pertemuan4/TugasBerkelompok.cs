using System;

namespace Pertemuan4
{
    // Nama Anggota Kelompok
    // Asraf Nabil Al Attar (4)
    // M Jalaluddin R (19)

    internal class TugasBerkelompok
    {
        static void Main(string[] args)
        {
            Console.WriteLine("       PROGRAM PENGELOLA NILAI SISWA         ");
            Console.WriteLine();

            string pilihan = "iya";

            while (pilihan == "iya")
            {
                Console.Write("Masukkan Nama Siswa : ");
                string nama = Console.ReadLine();

                Console.Write("Masukkan Nilai Tugas : ");
                double tugas = Convert.ToDouble(Console.ReadLine());

                Console.Write("Masukkan Nilai UTS : ");
                double uts = Convert.ToDouble(Console.ReadLine());

                Console.Write("Masukkan Nilai UAS : ");
                double uas = Convert.ToDouble(Console.ReadLine());

                Siswa siswa = new Siswa(nama, tugas, uts, uas);

                Console.WriteLine();
                siswa.TampilkanRapor();

                Console.WriteLine();
                Console.Write("Apakah Anda masih ingin memasukkan nilai siswa? (iya/tidak): ");
                pilihan = Console.ReadLine().ToLower();

                Console.WriteLine();
            }
        }
    }
}

class Siswa
{
    public string Nama;
    public double NilaiTugas;
    public double NilaiUTS;
    public double NilaiUAS;

    public Siswa(string nama, double nilaiTugas, double nilaiUTS, double nilaiUAS)
    {
        Nama = nama;
        NilaiTugas = nilaiTugas;
        NilaiUTS = nilaiUTS;
        NilaiUAS = nilaiUAS;
    }

    public double HitungNilaiAkhir()
    {
        return (NilaiTugas * 0.3) + (NilaiUTS * 0.35) + (NilaiUAS * 0.35);
    }

    public string Predikat(double nilaiAkhir)
    {
        if (nilaiAkhir >= 80)
            return "A";

        else if (nilaiAkhir >= 65)
            return "B";

        else
            return "C";
    }

    public void TampilkanRapor()
    {
        double nilaiAkhir = HitungNilaiAkhir();
        string predikat = Predikat(nilaiAkhir);

        Console.WriteLine();
        Console.WriteLine("          HASIL NILAI SISWA        ");
        Console.WriteLine("Nama Siswa  : " + Nama);
        Console.WriteLine("Nilai Tugas : " + NilaiTugas);
        Console.WriteLine("Nilai UTS   : " + NilaiUTS);
        Console.WriteLine("Nilai UAS   : " + NilaiUAS);
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Nilai Akhir : " + nilaiAkhir.ToString("F2"));
        Console.WriteLine("Predikat    : " + predikat);
        Console.WriteLine("===================================");
    }
}