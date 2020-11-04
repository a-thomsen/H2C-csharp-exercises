using System;

namespace exercise_13
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.Write("Give a double!");
      string userInput = Console.ReadLine();
      double doubleValue = Convert.ToDouble(userInput);
      Console.Write("You gave " + doubleValue);
    }
  }
}
