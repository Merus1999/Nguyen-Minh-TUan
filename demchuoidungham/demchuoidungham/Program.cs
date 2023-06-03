using System;
using System.Linq;
namespace ConsoleApp5
{
    class Program
    {
        static void demkytu(string s)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[0] == s[i])
                {
                    count++;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap vao chuoi: ");
            string s = Console.ReadLine();
            //Xóa khoảng trắng khỏi chuỗi
            s = s.Replace(" ", string.Empty);
            //sử dụng vòng lặp while và for để lặp và đếm số lần xuất hiện của ký tự
            while (s.Length > 0)
            {
                Console.Write(s[0] + " : ");
                int count = 0;
                for (int i = 0; i < s.Length; i++)//duyet vong lap
                {
                    if (s[0] == s[i])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                s = s.Replace(s[0].ToString(), string.Empty);

            }
            demkytu(s);
            Console.ReadKey();
        }
    }
}