using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_System
{
    internal class ArmstrongNumbers
    {
        public static void Main()
        {
            for (int i = 1; i <= 1000; i++)
            {
                int originalValue = i;
                int tempValue = originalValue;
                int digitCount = 0;
                int remainder;
                int poweredDigit;
                int armstrongSum = 0;

                while (tempValue > 0)
                {
                    tempValue = tempValue / 10;
                    digitCount++;
                }

                tempValue = originalValue;

                while (tempValue > 0)
                {
                    remainder = tempValue % 10;
                    poweredDigit = (int)Math.Pow(remainder, digitCount
                        );
                    armstrongSum = armstrongSum + poweredDigit;
                    tempValue = tempValue / 10;
                }

                if (armstrongSum == originalValue)
                {
                    Console.WriteLine(originalValue + " is Armstrong Number");
                }
            }
        }
    }
}
