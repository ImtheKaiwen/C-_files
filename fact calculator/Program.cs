using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fact_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // faktöryel hesaplama 
            // kullanıcıdan sayıyı al for döngüsü içerisinde hesaplat
            Bas:
            long s = 1;
           
            Console.WriteLine("Lütfen hesaplatmak istediğiniz bir sayıyı giriniz");
            int fakt= Convert.ToInt32(Console.ReadLine());
            for(long i=1;i<= fakt; i++)
            {
                s = s * i;
               
            }
            Console.WriteLine(s);
            goto Bas;
            Console.ReadLine();
        }
    }
}
