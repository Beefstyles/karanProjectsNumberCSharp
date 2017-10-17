using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaranNumberProjects
{
    class ModularExp
    {
        public static void ModularExpImplementation()
        {
            int baseDigit = 0;
            int powerDigit = 0;
            int result;
            bool correctInput = false;

            while (!correctInput)
            {
                Console.WriteLine("Enter base integer");
                if (Int32.TryParse(Console.ReadLine(), out baseDigit) && baseDigit > 0)
                {
                    Console.WriteLine("Enter power integer");
                    if(Int32.TryParse(Console.ReadLine(), out powerDigit) && powerDigit > 0)
                    {
                        correctInput = true;
                    }

                }
                else
                {
                    Console.WriteLine("Enter an integer");
                }

            }
            result = FastExp(baseDigit, powerDigit);

            Console.WriteLine("Result of {0}^{1} is {2}", baseDigit, powerDigit, result);
            
            Console.ReadKey();
        }

        private static int FastExp(int baseDigit, int powerDigit)
        {
            int result = 1;
            while(powerDigit > 0)
            {
                if(powerDigit % 2 == 0)
                {
                    baseDigit = (int)Math.Pow(baseDigit,2);
                    Console.WriteLine(baseDigit);
                    powerDigit /= 2;
                    Console.WriteLine("powr digt" + powerDigit);
                }
                else
                {
                    result = result * baseDigit;
                    powerDigit--;
                }
            }
            return result;
        }
    }

}
