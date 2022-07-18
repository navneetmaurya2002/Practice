using System;
using System.Linq;
using System.Text;


namespace BasicConApp
{
  public class Program
  {
    static void Main(string[] args)
    {
      #region Addition

      //Printer.PrintHeader("This is the program to find sum of multiple numbers", '-');
      //int num1 = 10, num2 = 20;
      //Console.WriteLine($"The Sum of is {NumberFunctions.AddNumbers(num1, num2, 12, 12, 14)}");
      //Printer.PrintFooter('-');
      //Printer.PrintHeader("This is a program to find sum of two numbers", '*');
      //Console.WriteLine($"The Sum of is {NumberFunctions.AddNumber(num1, num2)}");
      //Printer.PrintFooter('*', 100);
      #endregion

      #region Palindrome
      //String name = "navneet";
      //if (StringFunctions.isPalindrome(name))
      //{
      //  Console.WriteLine($"The name {name} is palindrome");
      //}
      //else
      //  Console.WriteLine($"The name {name} is not palindrome");

      #endregion

      #region Cardinal To Ordinal
      //int ctr = 1;
      //for (int i = 1; i <= 35; i++)
      //{

      //  Console.Write($"{StringFunctions.CardinalToOrdinal(i)}\t");
      //  if (ctr++ == 10)
      //  {
      //    Console.WriteLine();
      //    ctr = 1;
      //  }

      //}
      //Console.WriteLine();
      #endregion

      #region Arrays
      //int[] intArray = new int[10];

      //for (int i = 0; i < 10; i++)
      //{
      //  intArray[i] = (i * 2);
      //}
      //Printer.PrintHeader("Int Array");
      //int cnt = 1;
      //for (int i = 0; i < 10; i++)
      //{
      //  Console.WriteLine($"{cnt++} -- intArray[{i}]={intArray[i]}");
      //}
      //Printer.PrintFooter();

      #endregion

      #region string

      //String[] names = { "Tintin", "Snowy", "SpiderMan", "NItin", "Juliet", "Otto", "Simba", "Mogli" };
      //Printer.PrintHeader("String Array");
      //int ctr = 1;
      ////for(int i=0;i<name.Length;i++)
      ////{
      ////  Console.WriteLine($"{ctr++} -- name[{i}] -> {names[i]}");
      ////}

      //for (int i = 0; i < name.Length; i++)
      //{

      //  Console.Write($"{ctr++} -- name[{i}] -> {names[i]} is ");
      //  if (StringFunctions.isPalindrome(names[i].ToLower()))
      //  {
      //    Console.WriteLine("Palindrome");
      //  }
      //  else
      //    Console.WriteLine("not Palindrome");
      //}
      //Printer.PrintFooter();

      #endregion


      #region Person
      Person p1 = new Person();
      p1.AccepData();
      Console.WriteLine();
      p1.DisplayData(); 
      #endregion
    }
  }
}