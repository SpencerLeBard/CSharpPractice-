using System;

namespace helloworld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter Number");
      int num1 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter Number");
      int num2 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine(num1 + num2);
    }
  }
}
