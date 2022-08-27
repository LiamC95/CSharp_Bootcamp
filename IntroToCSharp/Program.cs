using System;

namespace IntroToCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 6;
            if (a + b > 10 && a > b)
                Console.WriteLine("True");
            else
                Console.WriteLine($"False");

        }
    }
}