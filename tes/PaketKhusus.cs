using System;
using System.Collections.Generic;
using System.Text;

namespace B_252410103036_ATHIRAH_ALYA_PUTERI_A
{
    public class PaketKhusus : PaketMBG
    {
        public string JenisDiet {get; set;}

        public PaketKhusus(string id, string nama, int stok, string jenisDiet) : base(id, nama, stok)
        {
            JenisDiet = jenisDiet;
        }

        public int HitungBiaya(int jumlah)
        {
            return jumlah * 20000;
        }
    }
}