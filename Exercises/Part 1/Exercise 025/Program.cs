using System;

namespace exercise_25
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.Write("Give a number");
      string input = Console.ReadLine();
      int number = Convert.ToInt32(input);
      if (number == 1984) 
      {
        Console.WriteLine("Orwell");
      }
    }
  }
}
