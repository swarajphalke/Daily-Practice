﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class Hollow_Full_Pyramid
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
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    if (j == 1 || j == 2 * i - 1 || i == n)
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
