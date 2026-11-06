using System;
using System.Collections.Generic;
using System.Text;

namespace B_252410103036_ATHIRAH_ALYA_PUTERI_A
{
    public class Sekolah
    {
        public string IdSekolah {get; set;}
        public string NamaSekolah {get; set;}
        public int JumlahPaketDiterima {get; private set;}

        public Sekolah(string idSekolah, string namaSekolah)
        {
            IdSekolah = idSekolah;
            NamaSekolah = namaSekolah;
            JumlahPaketDiterima = 0;
        }

        public void TerimaPaket(int jumlah)
        {
            if (jumlah > 0)
            {
                JumlahPaketDiterima += jumlah;
            }
        }

        public void TampilInfo()
        {
            Console.WriteLine("Id Sekolah: " + IdSekolah);
            Console.WriteLine("Nama Sekolah: " + NamaSekolah);
            Console.WriteLine("Jumlah Paket Diterima: " + JumlahPaketDiterima);
            Console.WriteLine();
        }
    }
}
