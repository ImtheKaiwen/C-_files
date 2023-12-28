using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // skaler çarpım yaptıran bir uygulama yap 
            // kullanıcıdan girdileri yap daha sonra işlemleri uygulat

            Console.WriteLine("lütfen sırasıyla x y z kordinatlarını giriniz");
            int x;
            x = Convert.ToInt32(Console.ReadLine());
            int y;
            y = Convert.ToInt32(Console.ReadLine());
            int z;
            z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen 2. vektörün x y z kordinatlarını giriniz");
            int x1;
            x1 = Convert.ToInt32(Console.ReadLine());
            int y1;
            y1 = Convert.ToInt32(Console.ReadLine());
            int z1;
            z1 = Convert.ToInt32(Console.ReadLine());

            int x2 = x * x1;
            int y2= y * y1;
            int z2= z * z1;

            Console.WriteLine("Answer :" + "" + "(" + x2 + "," + y2 + "," + z2 + ")");

            Console.ReadLine();

         
        }
    }
}
