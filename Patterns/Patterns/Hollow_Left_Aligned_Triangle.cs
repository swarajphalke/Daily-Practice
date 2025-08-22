using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class Hollow_Left_Aligned_Triangle
    {
        public static void Main()
        {
            int n = 4;
            //int count = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j == 1 || j == i || i == n)
                    {
                        Console.Write("* ");
                        //Console.Write(count++ + " ");
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
