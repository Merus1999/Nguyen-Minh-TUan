using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ktsonguyento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Moi ban nhap so n= ");
            int dem = 0; //đếm số ước số
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0) dem++;
            }
            if (dem == 2) Console.WriteLine(n + " la SNT");
            else Console.WriteLine(n + " ko la SNT");
            Console.ReadKey();
        

    }
}
}
