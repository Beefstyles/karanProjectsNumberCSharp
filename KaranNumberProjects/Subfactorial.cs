using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaranNumberProjects
{
    class Subfactorial
    {

        public static void FindSubFactorial()
        {
            bool correctInput = false;
            Console.WriteLine("Enter positive integer you require the subfactorial for");
            while (!correctInput)
            {
                if (Int32.TryParse(Console.ReadLine(), result: out int subfactInput) && subfactInput >= 0)
                {
                    int subFact = ReturnSubfact(subfactInput);
                    correctInput = true;
                    Console.WriteLine("Subfactorial of {0} is {1}", subfactInput, subFact);
                }
                else
                {
                    Console.WriteLine("Enter a positive integer");
                }
            }
            Console.ReadKey();
        }

        private static int ReturnSubfact(int inputNumber)
        {
            int sumVal = 0;
            int subFact = 0;
            for (int i = 1; i <= inputNumber; i++)
            {
                int val = 1 / ReturnFactorial(i);
                Console.WriteLine(val);
                if (i % 2 == 0)
                {
                    sumVal += val;
                    
                }
                else
                {
                    sumVal -= val;
                }
                
            }
            return subFact = ReturnFactorial(inputNumber) * (1 - sumVal);
        }

        private static int ReturnFactorial(int value)
        {
            int fact = value;
            for (int i = value -1 ; i >= 1; i--)
            {
                fact *= i;
            }
            return fact;
        }
    }
}
