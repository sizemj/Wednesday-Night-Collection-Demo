using System;

namespace Wednesday_Night_Collection_Demo_Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List of numbers divisible by 2");
int i = 0;
while (i < 101) 
{
   if ((i % 2) == 0)
            {
                Console.WriteLine(i);
            }
    i = i + 1;
}


 Console.WriteLine("List of numbers divisible by 5");
int a = 0;
while (a < 101) 
{
   if ((a % 5) == 0)
            {
                Console.WriteLine(a);
            }
    a = a + 1;
}


 Console.WriteLine("List of numbers divisible by 2 and 5");
int b = 0;
while (b< 101) 
{
   if(((b % 2) == 0) and ((b % 5) == 0)))
            {
                Console.WriteLine(b);
            }
            elseif((b % 2) != 0) or ((b % 5) != 0))
            {
              Console.WriteLine("the numbers is not divisible by 2 or 5") 
            }
    b = b + 1;
}
        }
    }
}
