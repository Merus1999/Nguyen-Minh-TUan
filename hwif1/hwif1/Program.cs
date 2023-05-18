using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwif1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("nhap a: ");
            a = int.Parse(Console.ReadLine());
            int b;
            Console.WriteLine("nhap b: ");
            b = int.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("phuong trinh ko co nghiem x = -b/a");
            }
            else if (a != 0 && b == 0)
            {
                Console.WriteLine("phuong trinh co vo so nghiem x");
            }
            else
            {
                Console.WriteLine("phuong trinh co 1 nghiem x = -b/a");
                Console.WriteLine(-b / a);
            }
            Console.ReadKey();
        }
    }
}
