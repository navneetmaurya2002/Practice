using System;

namespace BasicConApp
{
  public static class NumberFunctions
  {
    public static int AddNumbers(int value1, int value2, params int[] numbers)
    {
      int result = value1 + value2;
      for (int i = 0; i < numbers.Length; i++)
      {
        result += numbers[i];
      }
      return result;
    }

    public static int AddNumber(int value1, int value2)
    {
      return value1 + value2;
    }
    public static void Table(int n)
    {
      for (int i = 1; i <= 12; i++)
      {
        Console.WriteLine("{0} * {1}={2}", n, i, i * n);
      }
    }
    public static int fibonacci(int n)
    {
      if (n == 1)
      {
        return 0;
      }
      else if (n == 2)
      {
        return 1;
      }
      else
      {
        int num = fibonacci(n - 1) + fibonacci(n - 2);
        return num;
      }
    }
    public static int factorial(int n)
    {
      int fact = 1;
      for (int i = n; i >= 1; i--)
      {
        fact *= i;
      }

      return fact;
    }

   
  }


}
