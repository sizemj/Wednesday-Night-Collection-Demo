using System;

namespace Wednesday_Night_Collection_Demo_Code
{
    public static class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)

                if (i % 2 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i + " is divisible by 2 and 5");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(i + " is divisible by 5");
                }
                else if (i % 2 == 0)
                {
                    Console.WriteLine(i + " is divisible by 2");
                }
                else if (i % 2 != 0 || i % 5 != 0)
                {
                    Console.WriteLine(i + " Is not divisible by 2 or 5");
                }
            Console.ReadLine();
        }
    }
}
