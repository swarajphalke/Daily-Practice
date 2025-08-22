using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class Hollow_Right_Aligned_Triangle
    {
        public static void Main()
        {
            int n = 4;

            for (int i = 1; i <= n; i++)
            {
                for (int s = 1; s <= n - i; s++)
                {
                    Console.Write("  ");
                }
                for (int j = 1; j <= i; j++)
                {
                    if (j == 1 || i == j || i == n)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
