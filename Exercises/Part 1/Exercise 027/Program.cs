using System;

namespace exercise_27
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.Write("Give a number");
      string input = Console.ReadLine();
      int number = Convert.ToInt32(input);
      if (number > 0) 
      {
        Console.WriteLine("It is positive");
      }
      else 
      {
        Console.WriteLine("It is not positive");
      }
    }
  }
}
