using System;

namespace FizzBuzz
{
    public class Program
    {
        public static void Main()
        {
            for (int i = 1; i <= 100; i++)
            {
                string k = i.ToString();

                if (i % 3 == 0 | k.Contains("3"))
                {
                    if (i % 5 == 0 | k.Contains("5"))
                        Console.WriteLine("FizzBuzz");
                    else
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0 | k.Contains("5"))
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }
        }
    }
}
