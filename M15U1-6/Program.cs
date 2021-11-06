using System;
using System.Linq;
using System.Collections.Generic;

namespace M15U1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            var punctuation = new List<char>() { ' ', ',', '.', ';', ':', '?', '!' };

            var newText = text.Except(punctuation).ToArray();

            Console.WriteLine(newText);

            //foreach(var letter in newText)
            //    Console.WriteLine(letter);
        }
    }
}
