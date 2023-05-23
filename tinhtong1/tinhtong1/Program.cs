using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tinhtong1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];//Khai bao mang
            Console.Write("So luong phan tu can nhap: ");
            int n = int.Parse(Console.ReadLine());  //n la slpt
            Console.WriteLine("Nhap gia tri cac phan tu: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Phan tu thu [" + i + "]=");//Phan tu thu [0]= ???
                a[i] = int.Parse(Console.ReadLine()); //Luu gia tri vo mang
            }
            Console.WriteLine();
            Console.WriteLine("Xuat du lieu vua nhap:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            int tong = 0;
            for (int i = 0; i < n; i++) tong += a[i]; //tính tổng cộng dồn
            Console.WriteLine("Tong gia tri cua mang:" + tong);
            Console.ReadKey();

        }
    }
}
