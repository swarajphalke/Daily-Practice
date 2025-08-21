﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class Floyds_Triangle
    {
        public static void Main()
        {
            int n = 4;
            int count = 1;

            for(int i = 1; i<=n; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(count++ + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
