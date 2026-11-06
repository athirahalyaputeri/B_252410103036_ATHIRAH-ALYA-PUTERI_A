using System;

namespace B_252410103036_ATHIRAH_ALYA_PUTERI_A
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("================================");
            Console.WriteLine("       SISTEM MANAJEMEN MBG");
            Console.WriteLine("================================\n");

            Sekolah sekolah1 = new Sekolah("S01", "SD Negeri 1");
            Sekolah sekolah2 = new Sekolah("S02", "SD Negeri 2");

            Console.WriteLine("=== DATA SEKOLAH ===");

            sekolah1.TampilInfo();
            Console.WriteLine();

            sekolah2.TampilInfo();
            Console.WriteLine();

            PaketReguler reguler = new PaketReguler(
                "P01", "Paket Reguler", 100
            );

            PaketKhusus khusus = new PaketKhusus(
                "P02", "Paket Khusus", 50, "Rendah Gula"
            );

            Console.WriteLine("=== PERHITUNGAN BIAYA ===");

            PaketMBG paket1 = reguler;
            PaketMBG paket2 = khusus;

            Console.WriteLine("Biaya Paket Reguler: Rp" + paket1.HitungBiaya(10));
            Console.WriteLine("Biaya Paket Khusus: Rp" + paket2.HitungBiaya(10));
            Console.WriteLine();

            Console.WriteLine("=== PROSES DISTRIBUSI ===");

            DistribusiMBG distribusi1 = new DistribusiMBG(
                sekolah1, reguler, 30
            );

            distribusi1.KirimPaket();
            Console.WriteLine();

            DistribusiMBG distribusi2 = new DistribusiMBG(
                sekolah2, khusus, 60
            );

            distribusi2.KirimPaket();
            Console.WriteLine();
        }
    }
}