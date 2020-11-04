using System;

namespace exercise_26
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.Write("Give your birth year");
      string input = Console.ReadLine();
      int year = Convert.ToInt32(input);
      if (year < 1900) 
      {
        Console.WriteLine("You're old");
      }
    }
  }
}
