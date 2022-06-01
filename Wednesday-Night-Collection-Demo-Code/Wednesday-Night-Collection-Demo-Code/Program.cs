using System;
using System.Media;

namespace Wednesday_Night_Collection_Demo_Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool methodSucceeded = DetermineDivisible();
            if (methodSucceeded)
            {
                Console.WriteLine("Done determining divisibility!" + "\n");
                PlayASong();
            }
            else
            {
                Console.WriteLine("Oof, something went wrong!");
                PlayASong();
            }
        }

        //Put the for loop into a method to make the above easier to deal with.
        static bool DetermineDivisible()
        {
            for (int i = 0; i <= 100; i++)
            {

                //Determine whether i is divisible by 2, 5, or both 2 and 5, then print a message.
                if (Divisible(i, 2) == false && Divisible(i, 5) == false)
                {
                    Console.WriteLine("The number " + i + " is not divisible by 2 or 5.");
                }
                else if (Divisible(i, 2) == true && Divisible(i, 5) == true)
                {
                    Console.WriteLine("The number " + i + " is divisible by both 2 and 5.");
                }
                else if (Divisible(i, 2) == true && Divisible(i, 5) == false)
                {
                    Console.WriteLine("The number " + i + " is divisible by 2 but not 5.");
                }
                else if (Divisible(i, 2) == false && Divisible(i, 5) == true)
                {
                    Console.WriteLine("The number " + i + " is divisible by 5 but not 2.");
                }
                else
                {
                    Console.WriteLine("Something crazy happened with " + i + "!");
                    return false;
                }
            }
            return true;
        }

        
       //Method to determine if numbers are divisible
        static bool Divisible(int num1, int num2)
        {
            int numVar = (num1 % num2);
            if (numVar == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Just for fun
        static void PlayASong()
        {
            Console.WriteLine("Would you like to hear a song?");
            string answer = Console.ReadLine();
            if (answer == "yes" || answer == "Yes" || answer == "y" || answer == "Y")
            {
                try
                {
                    System.Media.SoundPlayer ik = new SoundPlayer();
                    ik.SoundLocation = Environment.CurrentDirectory + "/ik.wav";
                    ik.Play();
                    Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Sorry, maybe next time!");
                Console.ReadLine();
            }

        }

    }
}