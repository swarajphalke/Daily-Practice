using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Number_System;
namespace Number_System
{
    internal class Prime
    {
        public void CheckPrime(int number)
        {
            int count = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine(number + " is Prime");
            }
            else
            {
                Console.WriteLine(number + " is not Prime");
            }

        }
        public static void Main()
        {
            Prime p = new Prime();
            p.CheckPrime(13);
        }
    }
}
