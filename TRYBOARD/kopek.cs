using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRYBOARD
{
   
    public class Kopek : kedi
    {
        public int yas;
        public Kopek(int yas1, string adi, string oyuncakadi, int arkadassayisi) : base(yas1,adi,oyuncakadi,arkadassayisi)
        {
           yas = yas1;
        }
    }
}
