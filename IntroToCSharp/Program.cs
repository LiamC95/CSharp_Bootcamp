using System;
using System.Collections.Generic;

namespace IntroToCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "<name>", "Anna", "Brian" };
            names.Add("Liam");
            names.Remove("<name>");
            names.Add("Laurie");

            foreach (var name in names)
                Console.WriteLine(name);

            Console.WriteLine($"Found Laurie at {names.IndexOf("Laurie")}\n\n");
            /**
             * Sorting baby
             */
            names.Sort();
            foreach (var name in names)
                Console.WriteLine(name);

            Console.WriteLine($"Found Laurie at {names.IndexOf("Laurie")}\n\n");

            var fibonacciNumbers = new List<int> { 1, 1 };

            while (fibonacciNumbers.Count < 20)
                fibs(fibonacciNumbers);
            
            foreach (var num in fibonacciNumbers)
                Console.WriteLine(num);
        }
        static void fibs(List<int> fib)
        {
            var previous = fib[fib.Count - 1];
            var previous2 = fib[fib.Count - 2];
            fib.Add(previous + previous2);
        }
    }
}