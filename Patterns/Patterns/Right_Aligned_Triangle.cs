using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class Right_Aligned_Triangle
    {
        public static void Main()
        {
            int n = 4;
 
            for(int i = 1; i <= n; i++)
            {
                for(int j = 1; j <= n-i; j++)
                {
                    Console.Write(" ");
                }
                for(int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
