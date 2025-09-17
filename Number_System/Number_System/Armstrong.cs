using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_System
{
    internal class Armstrong
    {
        public static void Main()
        {
            int originalValue = 153;
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
                poweredDigit = (int)Math.Pow(remainder, digitCount);
                armstrongSum = armstrongSum + poweredDigit;
                tempValue = tempValue / 10;

            }

            if (originalValue == armstrongSum)
            {
                Console.WriteLine(originalValue + " is Armstrong");
            }
            else
            {
                Console.WriteLine(originalValue + " is not Armstrong");
            }
        }
    }
}
