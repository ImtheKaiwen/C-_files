using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cash_Bank_Updated
{
    internal class Musteriislemleri
    {
        private int mustyas;
        private string mustisim;
        private string mustsoyisim;
        private string mustdurum;
        private string mustbankhesabıdurumu;
        private int mustbakiye;

        public Musteriislemleri(int _mustyas,string _mustisim,string _mustsoyisim, string _mustdurum, string _mustbankhesabıdurumu,int _mustbakiye)
        {
            mustyas = _mustyas;
            mustisim = _mustisim;
            mustdurum = _mustdurum;
            mustbankhesabıdurumu = _mustbankhesabıdurumu;
            mustsoyisim = _mustsoyisim; 
            mustbakiye= _mustbakiye;
        }
        public void kullanicibilgileri()
        {
            Console.WriteLine("Müsterinin İsmi :"+ " "+mustisim);
            Console.WriteLine("Müşterinin Soyisimi :" + " " +mustsoyisim);
            Console.WriteLine("Müşterinin Yaşı :" + " " +mustyas);
            Console.WriteLine("Müşterinin Durumu :" + " " +mustdurum);
            Console.WriteLine("Müşterinin Daha önceki banka kartı durumu :" + " " +mustbankhesabıdurumu);
            Console.WriteLine("müşterinin bakiyesi :" + " " +mustbakiye);
            
        }



    }
}
