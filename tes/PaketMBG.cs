using System;
using System.Collections.Generic;
using System.Text;

namespace B_252410103036_ATHIRAH_ALYA_PUTERI_A
{
    public abstract class PaketMBG
    {
        private string idPaket;
        private string namaPaket;
        private int stokDapur;

        public string IdPaket
        {
            get {return idPaket;}
        }

        public string NamaPaket
        {
            get {return namaPaket;}
        }

        public int StokDapur
        {
            get {return stokDapur;}
        }

        public PaketMBG(string idPaket, string namaPaket, int stokDapur)
        {
            this.idPaket = idPaket;
            this.namaPaket = namaPaket;

            if (stokDapur >= 0)
            {
                this.stokDapur = stokDapur;
            }
            else
            {
                this.stokDapur = 0;
            }
        }

        public bool KurangiStok(int jumlah)
        {
            if (jumlah <= 0 || jumlah > stokDapur)
            {
                return false;
            }

            stokDapur -= jumlah;
            return true;
        }

        public abstract int HitungBiaya(int jumlah);
    }
}