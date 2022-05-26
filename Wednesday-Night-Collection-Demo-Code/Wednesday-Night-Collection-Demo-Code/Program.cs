using System;
using System.Collections.Generic;

namespace Wednesday_Night_Collection_Demo_Code
{
    internal class Program
    {
        static List<int> divisibleByTwo = new List<int>();
        static List<int> divisibleByFive = new List<int>();
        static List<int> divisibleByTwoAndFive = new List<int>();
        static List<int> notDivisibleByTwoOrFive = new List<int>();
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                if(i % 2 == 0 && i != 0)
                {
                    if(i % 5 == 0)
                    {
                            divisibleByTwoAndFive.Add(i);
                    }
                    divisibleByTwo.Add(i);
                }
                if(i % 5 == 0 && i != 0)
                {
                        divisibleByFive.Add(i);
                }
                if(i % 5 != 0 || i % 2 != 0 || i == 0)
                {
                        notDivisibleByTwoOrFive.Add(i);
                }
            }
            foreach (int a in divisibleByTwo)
            {
                Console.WriteLine($"{a} is divisible by Two!");
            }
            foreach(int b in divisibleByFive)
            {
                Console.WriteLine($"{b} is divisible by Five!");
            }
            foreach(int c in divisibleByTwoAndFive)
            {
                Console.WriteLine($"{c} is divisible by Two and Five!");
            }
            foreach(int d in notDivisibleByTwoOrFive)
            {
                if (d % 2 != 0 || d == 0)
                {
                    Console.WriteLine($"{d} was not divisible by Two!");
                }
                if (d % 5 != 0 || d == 0)
                {
                    Console.WriteLine($"{d} was not divisible by Five!");
                }
            }
        }
    }
}
