using System;
using System.Collections.Generic;
using System.Linq;

namespace M15U2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Factorial(a));
        }

        static long Factorial(int number)
        {
            var numbers = new List<int>();

            for (int i = 1; i <= number; i++)
                numbers.Add(i);

            return numbers.Aggregate((x, y) => x * y);
        }
    }
}
