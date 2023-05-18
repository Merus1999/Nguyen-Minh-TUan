using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwif2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double height;
            double weight;
            Console.WriteLine("nhap chieu cao: ");
            height = double.Parse(Console.ReadLine());
            Console.WriteLine("nhap can nang: ");
            weight = double.Parse(Console.ReadLine());
            //bmi là chí số cơ thể ==> công thức bmi = weight/height^2
            double bmi = weight / (height*height);//có thể dùng math.pow là công thức tính mũ math.pow(ten_bien,số lần mũ)
            bmi = Math.Round(bmi, 1);//math.roung là công thức làm tròn 
            Console.WriteLine("BMI: " + bmi);
            if (bmi < 18)
            {
                Console.WriteLine(" Underweight");
            }
            else if (bmi < 25.0)
            {
                Console.WriteLine(" Normal");
            }
            else if (bmi < 30.0)
            {
                Console.WriteLine(" Overweight");
            }
            else
            {
                Console.WriteLine(" Obese");
            }
            Console.ReadKey();
        }

    }
}
