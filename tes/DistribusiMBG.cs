using System;
using System.Collections.Generic;
using System.Text;

namespace B_252410103036_ATHIRAH_ALYA_PUTERI_A
{
    public class DistribusiMBG : DapatDidistribusikan
    {
        private Sekolah sekolahTujuan;
        private PaketMBG paket;
        private int jumlah;

        public DistribusiMBG(Sekolah sekolah, PaketMBG paket, int jumlah)
        {
            this.sekolahTujuan = sekolah;
            this.paket = paket;
            this.jumlah = jumlah;
        }

        public KirimPaket()
        {
            if (jumlah >= 0)
            {
                Console.WriteLine("Distribusi gagal! Jumlah paket harus lebih dari 0");
                return;
            }

            if (jumlah < paket.StokDapur)
            {
                Console.WriteLine("Distribusi gagal! Stok dapur tidak mencukupi");
                return;
            }

            bool berhasil = paket.KurangiStok(jumlah);

            if (berhasil)
            {
                sekolahTujuan.TerimaPaket(jumlah);

                Console.WriteLine("Distribusi MBG berhasil! Sebanyak " + jumlah + "paket makanan telah dikirim ke sekolah " + sekolahTujuan.NamaSekolah);
            }
            else
            {
                Console.WriteLine("Distribusi gagal! Pengiriman tidak berhasil");
            }
        }
    }
}