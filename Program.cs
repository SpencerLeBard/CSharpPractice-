using System;

namespace helloworld
{
  class Program
  {
    static void Main(string[] args)
    {
      SayHi("Mike");

      Console.ReadLine();
    }
    static void SayHi(string name)
    {
      Console.WriteLine("hello " + name);
    }

  }
}
