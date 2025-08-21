using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class Small_Alphabet_Pyramid
    {
        public static void Main()
        {
            int n = 5;

            for (int i = 1; i <= n; i++)
            {
                for (int s = 1; s <= n - i; s++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write((char)(96 + j) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
