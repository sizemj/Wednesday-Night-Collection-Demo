using System;

namespace Wednesday_Night_Collection_Demo_Code
{
    public class example
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i + " is divisible by both!");
                }
                else if (i % 2 == 0)
                {
                    Console.WriteLine(i + " is divisible by two");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(i + " is divisible by five");
                }
                else
                {
                    Console.WriteLine(i + " indivisible by either number");
                }
            }
        }
    }
}
