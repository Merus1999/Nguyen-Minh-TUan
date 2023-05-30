using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ungdunginraloaihinhdungfor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = -1;
            while (choice != 0)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Print the rectangle");
                Console.WriteLine("2. Print the square triangle");
                Console.WriteLine("3. Print isosceles triangle");

                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your choice: ");
                choice = Int32.Parse(Console.ReadLine());
                int i, j;
                int k;
                int m;// m la cr
                int n;// n la cd
                int l;
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Print the rectangle");
                        Console.WriteLine("nhap m");
                        m = int.Parse(Console.ReadLine());
                        Console.WriteLine("nhap n");
                        n = int.Parse(Console.ReadLine());
                        for (i = 1; i <= m; i++)
                        {
                            for (j = 1; j <= n; j++)
                            {
                                Console.Write(" * ");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 2:
                        Console.WriteLine("Print the square triangle");
                        Console.WriteLine("nhap k: ");
                        k = Convert.ToInt32(Console.ReadLine());
                        for (i = 1; i <= k; i++)
                        {// vong 1 in ra tu 1 den n so dong
                            for (j = 1; j <= i; j++)
                            {
                                Console.Write(" * ");


                            }
                            Console.Write("\n");// in ra gia tri tung dong của  roi xuong dong
                        }
                        break;
                    case 3:
                        Console.WriteLine("Print isosceles triangle");
                        Console.WriteLine("nhap l: ");
                        l = Convert.ToInt32(Console.ReadLine());
                        for (i = l; i >= 1; i--)
                        {// vong 1 in ra tu 1 den n so dong
                            for (j = 1; j <= i; j++)
                            {
                                Console.Write(" * ");


                            }
                            Console.WriteLine("\n");// in ra gia tri tung dong của  roi xuong dong
                        }

                        break;

                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }

            }
        }
    }
}
