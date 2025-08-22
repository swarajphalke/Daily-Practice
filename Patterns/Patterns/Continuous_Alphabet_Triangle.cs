using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class Continuous_Alphabet_Triangle
    {
        public static void Main()
        {
            int n = 5;
            char letter = 'A';
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(letter++ + " ");
                    //letter++
                }
                Console.WriteLine();
            }
        }
    }
}
