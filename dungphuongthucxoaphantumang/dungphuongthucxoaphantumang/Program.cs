/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld
{
    static void xoaphantu(int[] arr, int index_del, int n)
    {
        for (int i = index_del; i < n - 1; i++)
        {
            arr[i] = arr[i + 1];
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
    static void Main()
    {
        //in ra cau nhap phan tu n
        Console.WriteLine("nhap so phan tu n:");
        int n;//khai báo bien n là số luong phan tu trong  mang

        n = int.Parse(Console.ReadLine());//nhap gia tri cho bien n

        int[] arr = new int[n];//khai bao mang arr vs so luong n phan tu
                               //nhap phann tu trong mang
        for (int i = 0; i < n; i++)
        {///duyet mang
            arr[i] = int.Parse(Console.ReadLine());//nhap mang ra mang arr[i]
        }
        //in mang
        for (int i = 0; i < n; i++)
        {//duyet mang
            Console.Write(arr[i] + " ");//in mang arr[i]
        }
        //phan tu can xoa
        Console.WriteLine("phan tu can xoa: ");
        int m;//khai bao bien m phan tu xoa trong mang
        m = int.Parse(Console.ReadLine());//nhap gia tri bien m de xoa

        for (int index_del = 0; index_del < n; index_del++)//duyet mang
            if (arr[index_del] == m)
            { //dieu kieu kiem gia tri bien m de xoa phan tu cua mang 
                Console.WriteLine("vi tri cua m la " + index_del);//in ra vi tri
                xoaphantu(arr, index_del, n);///tham chieu --de xao phan tu
            }
        Console.ReadKey();
    }
}