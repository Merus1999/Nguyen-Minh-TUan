using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tìm_giá_trị_trong_mảng
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nhap du lieu
            string[] dssv = new string[10];//Khai bao mang
            Console.Write("So luong phan tu can nhap: ");
            int n = int.Parse(Console.ReadLine());  //n la slpt
            Console.WriteLine("Nhap gia tri cac phan tu: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Phan tu thu [" + i + "]=");//Phan tu thu [0]= ???
                dssv[i] = Console.ReadLine(); //Luu gia tri vo mang
            }
            Console.WriteLine();
            //Tim kiem
            string hoten = ""; //tim kiem theo ho ten
            Console.Write("Nhap ho ten can tim: ");
            hoten = Console.ReadLine();
            

            int index = dssv.ToList().IndexOf(hoten);
            if (index < 0)
                Console.Write("Khong tim thay");
            else Console.Write("Da tim thay, vi tri thu " + index);
            Console.ReadKey();
        }
    }
}
