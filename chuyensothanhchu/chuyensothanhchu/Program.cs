using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuyensothanhchu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap so: ");
            string input = Console.ReadLine();
            int dodai = input.Length;
            if (dodai == 3)
            {
                int hangtram = int.Parse(input.Substring(0,1));
                switch(hangtram)
                {
                    case 1: Console.WriteLine("mot tram"); break;
                    case 2: Console.WriteLine("hai tram"); break;
                    case 3: Console.WriteLine("ba tram"); break;
                    case 4: Console.WriteLine("bon tram"); break;
                    case 5: Console.WriteLine("nam tram"); break;
                    case 6: Console.WriteLine("sau tram"); break;
                    case 7: Console.WriteLine("bay tram"); break;
                    case 8: Console.WriteLine("tam tram"); break;
                    case 9: Console.WriteLine("chin tram"); break;
                }
                int hangchuc = int.Parse(input.Substring(1, 1));
                switch (hangchuc)
                {
                    case 0: Console.WriteLine("");break;
                    case 1: Console.WriteLine("muoi"); break;
                    case 2: Console.WriteLine("hai muoi"); break;
                    case 3: Console.WriteLine("ba muoi"); break;
                    case 4: Console.WriteLine("bon muoi"); break;
                    case 5: Console.WriteLine("nam muoi"); break;
                    case 6: Console.WriteLine("sau muoi"); break;
                    case 7: Console.WriteLine("bay muoi"); break;
                    case 8: Console.WriteLine("tam muoi"); break;
                    case 9: Console.WriteLine("chin muoi"); break;
                }
                int donvi = int.Parse(input.Substring(2, 1));
                switch (donvi)
                {
                    case 0: Console.WriteLine(""); break;
                    case 1: Console.WriteLine("mot"); break;
                    case 2: Console.WriteLine("hai "); break;
                    case 3: Console.WriteLine("ba "); break;
                    case 4: Console.WriteLine("bon "); break;
                    case 5: Console.WriteLine("nam "); break;
                    case 6: Console.WriteLine("sau "); break;
                    case 7: Console.WriteLine("bay "); break;
                    case 8: Console.WriteLine("tam "); break;
                    case 9: Console.WriteLine("chin "); break;
                }
            }
            if (dodai == 2)
            {
                int hangchuc = int.Parse(input.Substring(0, 1));
                switch (hangchuc)
                {
                    
                    case 1: Console.WriteLine("muoi"); break;
                    case 2: Console.WriteLine("hai muoi"); break;
                    case 3: Console.WriteLine("ba muoi"); break;
                    case 4: Console.WriteLine("bon muoi"); break;
                    case 5: Console.WriteLine("nam muoi"); break;
                    case 6: Console.WriteLine("sau muoi"); break;
                    case 7: Console.WriteLine("bay muoi"); break;
                    case 8: Console.WriteLine("tam muoi"); break;
                    case 9: Console.WriteLine("chin muoi"); break;
                }
                int donvi = int.Parse(input.Substring(1, 1));
                switch (donvi)
                {
                    case 0: Console.WriteLine(""); break;
                    case 1: Console.WriteLine("mot"); break;
                    case 2: Console.WriteLine("hai "); break;
                    case 3: Console.WriteLine("ba "); break;
                    case 4: Console.WriteLine("bon "); break;
                    case 5: Console.WriteLine("nam "); break;
                    case 6: Console.WriteLine("sau "); break;
                    case 7: Console.WriteLine("bay "); break;
                    case 8: Console.WriteLine("tam "); break;
                    case 9: Console.WriteLine("chin "); break;
                }
            }
            if (dodai == 1)
            {
                int donvi = int.Parse(input.Substring(0, 1));
                switch (donvi)
                {
                    case 0: Console.WriteLine(""); break;
                    case 1: Console.WriteLine("mot"); break;
                    case 2: Console.WriteLine("hai "); break;
                    case 3: Console.WriteLine("ba "); break;
                    case 4: Console.WriteLine("bon "); break;
                    case 5: Console.WriteLine("nam "); break;
                    case 6: Console.WriteLine("sau "); break;
                    case 7: Console.WriteLine("bay "); break;
                    case 8: Console.WriteLine("tam "); break;
                    case 9: Console.WriteLine("chin "); break;
                }
            }
            Console.ReadKey();
        }
    }
}
