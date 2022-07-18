using System;

namespace BasicConApp
{
  public static class Printer
  {
    public static void PrintHeader(string message,char pattern='-', int noOfPattern=100)
    {
      int n = 0;
      int len = 0;
      if (!string.IsNullOrEmpty(message))
      {
         len = message.Length;
         n = noOfPattern - len;
        if (n % 2 == 0)
        {
          for (int i = 0; i < n / 2; i++)
          {
            Console.Write(pattern);
          }
        }
        else
        {
          for (int i = 0; i < n / 2 + 1; i++)
          {
            Console.Write(pattern);

          }

        }
      }
      Console.Write(message);
      for (int i = 0; i < n / 2; i++)
      {
        Console.Write(pattern);
      }
      Console.WriteLine();
    }
    public static void PrintFooter(char pattern='-', int noOfPattern=100)
    {
      for (int i = 1; i <= noOfPattern; i++)
      {
        Console.Write(pattern);
      }
      Console.WriteLine();
      Console.WriteLine();
    }
  }
}

