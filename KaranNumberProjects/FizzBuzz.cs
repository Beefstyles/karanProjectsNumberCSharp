﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaranNumberProjects
{
    class FizzBuzz
    {
        public static void FizzBuzzImplementation()
        {
            for (int i = 1; i <= 100; i++)
            {
                if(i % 3 == 0)
                {
                    Console.Write("Fizz");
                }

                if (i % 5 == 0)
                {
                    Console.Write("Buzz");
                }

                if (i % 3 != 0 && i % 5 != 0)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

    }
}
