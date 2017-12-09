using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1__multiplication_tab_
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;

            for (int i = 2; i <= 9; i++)
            {
                for (int j = 2; j <= 9; j++)
                {
                    Console.SetCursorPosition(x, y + j);
                    Console.WriteLine($"{i} x {j} = {i * j,2}");
                }
                x += 15;
                if (i == 5)
                    Console.SetCursorPosition(x = 0, y = 9);

            }
        }
    }
}
