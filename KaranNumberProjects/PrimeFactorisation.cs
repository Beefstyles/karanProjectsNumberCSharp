using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaranNumberProjects
{
    class PrimeFactorisation
    {
        public static void PrimeFactor()
        {
            int digit = 0;
            bool correctInput = false;


            while (!correctInput)
            {
                Console.WriteLine("Find all unique prime factor(s) for input");
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

            Console.WriteLine("Finding unique prime factor(s) for {0}", digit);
            RtnPrimeFactors(digit);

            Console.ReadKey();
        }

        static void RtnPrimeFactors(int factor)
        {
            List<int> primeFactors = new List<int>();
            //Prints the numbers of 2 that divide into factor
            while (factor % 2 == 0)
            {
                //i.e. there is a factor of 2 here
                primeFactors.Add(2);
                factor /= 2;
            }

            //factor is now odd so start a loop from i = 3 to the square root of factor. While i is a factor of the factor, increment i by 2 and continue
            for (int i = 3; i <= Math.Sqrt(factor); i+=2)
            {
                while (factor % i == 0)
                {
                    primeFactors.Add(i);
                    factor /= i;
                }
            }

            //If factor is prime and greater than 2 then factor will not become 1 by above 2 steps so itself is a factor
            if(factor > 2)
            {
                primeFactors.Add(factor);
            }
            primeFactors = primeFactors.Distinct().ToList();
            foreach (var primeFactor in primeFactors)
            {
                Console.WriteLine(primeFactor);
            }
        }

    }
}
