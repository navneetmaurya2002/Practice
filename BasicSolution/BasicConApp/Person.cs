using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConApp
{
  public class Person
  {
    private string _name;
    private int _age;
    public void AccepData()
    {
      Console.Write("Enter Name:");
      _name=Console.ReadLine();
      Console.Write("Enter Age:");
      _age = Convert.ToInt32( Console.ReadLine());
    }
    public void DisplayData()
    {
      Console.WriteLine($"Name: {_name} and Age: {_age}");
    }
  }
}
