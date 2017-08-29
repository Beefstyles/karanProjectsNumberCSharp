using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaranNumberProjects
{
    class PiToNthDigit
    {
        int count = 0;
        const int ARRINT = 2000;
        const int SCALE = 10000;

        public void CalculatePiToNthDigit()
        {
            int digit = 0;
            bool correctInput = false;

            while (!correctInput)
            {
                Console.WriteLine("Find pi to the nth digit");
                if (Int32.TryParse(Console.ReadLine(), out digit))
                {
                    if (digit > 0)
                    {
                        correctInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Ensure input greater than zero");
                    }
                }
                else
                {
                    Console.WriteLine("Enter an integer");
                }
                
        }
        
            Console.WriteLine("Finding pi to {0}th digit", digit);

            Console.WriteLine(piReturn(digit));
            Console.ReadKey();
        }

        string piReturn(int digits)
        {
            StringBuilder pi = new StringBuilder();
            int[] array = new int[digits + 1];
            int carry = 0;

            for (int i = 0; i < digits; ++i)
            {
                array[i] = ARRINT;
            }

            for (int i = digits; i > 0; i-= 14)
            {
                int sum = 0;
                for (int j = i; j > 0; --j)
                {
                    sum = sum * j + SCALE * array[j];
                    array[j] = sum % (j * 2 - 1);
                    sum /= j * 2 - 1;
                }
                pi.Append((carry + sum / SCALE).ToString());
                carry = sum % SCALE;
            }
            string piString = pi.ToString().Remove(1, 2);

            return "3." + piString;
        }


    }
}
