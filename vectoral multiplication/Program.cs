using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vectoral_multiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //take as x y z 
            // gonna be x.x=0 0
            // i.j=k jk=i ki=j j.i=-k k.j=-i i.k=-j 

            Console.WriteLine("let us know the x y z elements of your vector :");
            int axi;
            axi= Convert.ToInt32(Console.ReadLine());
            int ayj;
            ayj= Convert.ToInt32(Console.ReadLine());
            int azk;
            azk= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Let us know the x y z elements of your second vector");
            int bxi;
            bxi= Convert.ToInt32(Console.ReadLine());
            int byj;
            byj= Convert.ToInt32(Console.ReadLine());
            int bzk;
            bzk= Convert.ToInt32(Console.ReadLine());

            int a = axi * byj; //k
            int b = axi * bzk; //-j
            int c = ayj * bxi; //-k
            int d = ayj * bzk; //i
            int e = azk * bxi; //j
            int f = azk * byj; //-i

            Console.WriteLine("Multiplication result :" + "" + (d - f) + "," + (e - b) + "," + (a - c));
            Console.ReadLine();
            
        }
    }
}
