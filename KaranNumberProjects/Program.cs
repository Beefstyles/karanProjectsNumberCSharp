﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaranNumberProjects
{
    class Program
    {
        static void Main()
        {
            PiToNthDigit piToNthDigit = new PiToNthDigit();
            piToNthDigit.CalculatePiToNthDigit();

            /*int count = 0;
            int total = Recursive(5, ref count);

            Console.WriteLine(total);
            Console.WriteLine(count);
            Console.ReadKey();
            */
        }

        static int Recursive(int value, ref int count)
        {
            count++;
            if(value >= 10)
            {
                return value;
            }
            return Recursive(value + 1, ref count);
        }
    }
}
