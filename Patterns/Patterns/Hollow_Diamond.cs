using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class Hollow_Diamond
    {
        public static void Main()
        {
            int n = 4;

            //upper half
            for (int i = 1; i <= n; i++)
            {
                for (int s = 1; s <= n - i; s++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    if (j == 1 || j == 2 * i - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            //lower half
            for (int i = n - 1; i >= 1; i--)
            {
                for (int s = 1; s <= n - i; s++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    if (j == 1 || j == 2 * i - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
