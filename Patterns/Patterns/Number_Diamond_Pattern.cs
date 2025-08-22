using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class Number_Diamond_Pattern
    {
        public static void Main()
        {
            int n = 5;

            for(int i = 1; i<=n; i++)
            {
                for(int s = 1; s<=n-i; s++)
                {
                    Console.Write(" ");
                }
                for(int j = 1; j<=i; j++)
                {
                    Console.Write(j);
                }
                for(int j = i -1; j >=1; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

            for(int i = n-1; i>=1; i--)
            {
                for(int s = 1; s<=n-i; s++)
                {
                    Console.Write(" ");
                }
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                for(int j = i-1;j>=1; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
