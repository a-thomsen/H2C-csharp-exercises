using System;

namespace exercise_17
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("Give me a number!");
      int first = Console.ReadLine();
      Console.WriteLine("Give me another number!");
      int second = Console.ReadLine();
      Console.WriteLine("The sum of these numbers is " + (first + second));
    }
  }
}
