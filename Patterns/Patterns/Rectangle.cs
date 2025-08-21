using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class Rectangle
    {
        public static void Main()
        {
            int n = 4;
            int cols = 6;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= cols; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
