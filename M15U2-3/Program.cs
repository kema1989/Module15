using System;
using System.Collections.Generic;
using System.Linq;

namespace M15U2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ArithmeticMean(2, 7, 9, -7, 6, 3));
        }

        static double ArithmeticMean(params int[] numbers)
        {
            return Math.Round(numbers.Sum() / (double)numbers.Length , 7);
        }
    }
}
