using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thamphantumang
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int[] arr1 = new int[10];
        int i, n, p, x;

        Console.WriteLine("Chen phan tu vao mang trong C#: ");
       
        Console.Write("Nhap kich co mang: ");
        n = int.Parse(Console.ReadLine());
        /* nhap cac phan tu vao trong mang*/
        Console.WriteLine("Nhap {0} phan tu vao trong mang: ", n);
        for (i = 0; i < n; i++)
        {
            Console.Write("Phan tu - {0}: ", i);
            arr1[i] = int.Parse(Console.ReadLine());
        }


        Console.Write("Nhap gia tri phan tu moi can chen: ");
        x = int.Parse(Console.ReadLine());
        Console.Write("Nhap vi tri can chen phan tu moi nay: ");
        p = int.Parse(Console.ReadLine());

        Console.WriteLine("In mang ban dau:");
        for (i = 0; i < n; i++)
            Console.Write("{0} ", arr1[i]);
        /* di chuyen vi tri cac phan tu ben phai cua mang */
        for (i = n; i >= p; i--)
            arr1[i] = arr1[i - 1];
        /* chen gia tri vao vi tri da cho */
        arr1[p - 1] = x;


        Console.WriteLine("Sau khi chen phan tu, mang co dang: ");
        for (i = 0; i <= n; i++)
            Console.Write("{0} ", arr1[i]);
        Console.WriteLine();

        Console.ReadKey();
    }
    }
}
