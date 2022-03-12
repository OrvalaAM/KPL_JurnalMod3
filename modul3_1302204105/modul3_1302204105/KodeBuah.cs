using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul3_1302204105
{
    internal class KodeBuah
    {
        string[] namaBuah = {"Apel", "Aprikot", "Alpukat", "Pisang", "Paprika", "Blackberry", "Ceri", 
            "Kelapa", "Jagung", "Kurma", "Durian", "Anggur", "Melon", "Semangka"};
        string[] kodeBuah = {"A00", "B00", "C00", "D00", "E00", "F00", 
            "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00"};

        public void getKodeBuah(String nama)
        {
            int panjang = namaBuah.Length;
            for(int i = 0; i < panjang; i++)
            {
                if(nama == namaBuah[i])
                {
                    Console.WriteLine(kodeBuah[i]);
                    break;
                }
            }
        }
    }
}
