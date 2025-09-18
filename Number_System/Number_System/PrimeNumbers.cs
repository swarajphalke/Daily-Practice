using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_System
{
    internal class PrimeNumbers
    {
        public static void Main()
        {
            for (int i = 1; i <= 100; i++)
            {
                int number = i;
                int count = 0;

                for (int j = 1; j <= number; j++)
                {
                    if (number % j == 0)
                    {
                        count++;
                    }
                }
                
                if (count == 2)
                {
                    Console.WriteLine(number + " is Prime ");
                }
                else
                {
                    Console.WriteLine(number + " is not Prime ");
                }
            }
        }
    }
}
