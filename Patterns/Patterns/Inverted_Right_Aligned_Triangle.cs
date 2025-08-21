using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class Inverted_Right_Aligned_Triangle
    {
        public static void Main()
        {
            int n = 5;

            for (int i = n; i >= 1; i--)
            {
                for (int s = 1; s <= n - i; s++)
                {
                    Console.Write("  ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
