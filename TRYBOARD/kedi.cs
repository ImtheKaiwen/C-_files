using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRYBOARD
{
    public class kedi
    {
        public int kedininyasi;
        public string kedininadi;
        public string kedininoyuncagı;
        public int kedininarkadaslari;

        public kedi(int yas, string adi, string kedininoyuncag, int kedinarkadaslari)
        {
            kedininyasi = yas;
            kedininadi = adi;
            kedininarkadaslari = kedinarkadaslari;
            kedininoyuncagı = kedininoyuncag;
        }
      public void kedibilgileri()
        {
            Console.WriteLine("Kedinin adı" + kedininadi);
            Console.WriteLine("Kedinin yaşı"+ kedininyasi);
            Console.WriteLine("Kedinin arkadaş sayısı"+kedininarkadaslari);
            Console.WriteLine("Kedinin oyuncağının adı"+kedininoyuncagı);
        }
    }
}
