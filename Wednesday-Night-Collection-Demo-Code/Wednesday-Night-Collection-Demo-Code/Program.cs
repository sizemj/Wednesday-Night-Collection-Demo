namespace Wednesday_Night_Collection_Demo_Code
{
  class Program
  {
    static void Main(string[] args)
    {
      for (int i = 1; i <= 100; i++)
      {
        if (i % 2 == 0 && i % 5 == 0)
        {
          Console.WriteLine(i + " is divisible by two and five.");
        }
        else if (i % 2 == 0)
        {
          Console.WriteLine(i + " is divisible by two.");
        }
        else if (i % 5 == 0)
        {
          Console.WriteLine(i + " is divisible by five.");
        }
        else
        {
          Console.WriteLine(i + " is not divisible by two or five.");
        }
      }
    }
  }