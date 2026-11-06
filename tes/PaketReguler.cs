using System;
using System.Collections.Generic;
using System.Text;

namespace B_252410103036_ATHIRAH_ALYA_PUTERI_A
{
    public class PaketReguler : PaketMBG
    {
        public PaketReguler(string id, string nama, int stok) : base(id, nama, stok)
        {
        }

        public override int HitungBiaya(int jumlah)
        {
            return jumlah * 15000;
        }
    }
}