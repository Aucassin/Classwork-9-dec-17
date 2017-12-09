using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_9_dec_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i <= number; i++)
            {
                for (int j = 0; j <= number; j++)
                {
                    if (i == 0 || i == number - 1)
                        Console.Write('*');
                    else if (j == 0 || j == number - 1)
                        Console.Write('*');
                    else
                        Console.Write(' ');
                }
                Console.WriteLine();
            }
            //}
            //int repeat = number;
            //while (repeat > 0)
            //{
            //    for (int j = 0; j <= number; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //    repeat--;
            //}
            //for (int i = number; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
        }
    }
}


