/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
using System.Data.Common;

class HelloWorld
{
    static void Main()
    {
        int[,] matrix = new int[3, 3];
        Console.WriteLine("Enter " + matrix.GetLength(0) + " rows and " + matrix.GetLength(1) + " columns: ");
        //nhap mảng bằng tay
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                matrix[row, column] = Int32.Parse(Console.ReadLine());
            }
        }

        //nhap mang ngau nhien
        /*  Random rand = new Random();
          for (int row = 0; row < matrix.GetLength(0); row++)
          {
              for (int column = 0; column < matrix.GetLength(1); column++)
              {
                  matrix[row, column] = rand.Next() * 100;
              }
          }*/

        //in mảng
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            Console.WriteLine("\n");
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                Console.Write(matrix[row, column] + " ");
            }
        }
        // Tìm giá trị lớn nhất trong mảng
        int gtln = matrix[0, 0];
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                if (matrix[row, column] > gtln)
                {
                    gtln = (matrix[row, column]);
                }
            }

        }
        Console.WriteLine("\nGia tri lon nhat la:");
        Console.Write(gtln + " ");
        Console.ReadKey();
    }
}


