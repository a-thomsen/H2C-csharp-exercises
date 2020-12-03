using System;

namespace exercise_12
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give an integer!");
      string userInput = Console.ReadLine();
      int intValue = Convert.ToInt32(userInput);
      Console.WriteLine("You gave " + intValue);
    }
  }
}
