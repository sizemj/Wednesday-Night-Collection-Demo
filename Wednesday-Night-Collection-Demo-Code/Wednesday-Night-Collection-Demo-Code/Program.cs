using System;

namespace Wednesday_Night_Collection_Demo_Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool div2;
            bool div5;
            bool div2and5;
            //float result;
            for (int i = 0; i <= 100; i++)
            {
                //For some reason, I could not get this to work when declaring the booleans above as false and not including else statements below. The variables div2 and div5 would always return true no matter what was in the actual if statement. This may have been covered in class, but I'm not sure the reasoning behind that.
                //It was driving me crazy, and I thought the code commented out below was what fixed it, but adding the else statements did the trick with a simpler calculation.

                //result = ((float)i / 2);
                //if (Math.Floor(result) == result)
                //{
                //    div2 = true;
                //}
                //else
                //{
                //    div2 = false;
                //}

                //Determine whether i is divisible by 2, 5, or both 2 and 5.
                if (i % 2 == 0)
                {
                    div2 = true;
                }
                else
                {
                    div2 = false;
                }

                if (i % 5 == 0)
                {
                    div5 = true;
                }
                else
                {
                    div5 = false;
                }

                if (div2 == true && div5 == true)
                {
                    div2and5 = true;
                }
                else
                {
                    div2and5 = false;
                }

                //Print a message to the console for each number based on the results.
                //This could definitely be done much cleaner. Maybe another night.
                if (div2 == false && div5 == false && div2and5 == false)
                {
                    Console.WriteLine("The number " + i + " is not divisible by 2 or 5.");
                }
                else if (div2and5 == true)
                {
                    Console.WriteLine("The number " + i + " is divisible by both 2 and 5.");
                }
                else if (div2 == true && div5 == false)
                {
                    Console.WriteLine("The number " + i + " is divisible by 2 but not 5.");
                }
                else if (div2 == false && div5 == true)
                {
                    Console.WriteLine("The number " + i + " is divisible by 5 but not 2.");
                }
                else
                {
                    Console.WriteLine("Something crazy happened with " + i + "!");
                }
            }
        }
    }
}