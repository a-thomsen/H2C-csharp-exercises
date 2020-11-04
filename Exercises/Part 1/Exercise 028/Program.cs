using System;

namespace exercise_28
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.Write("How old are you?");
      string input = Console.ReadLine();
      int age = Convert.ToInt32(input);
      if (age >= 18) 
      {
        Console.WriteLine("You're an adult!");
      }
      else 
      {
        Console.WriteLine("You're underaged!");
      }
    }
  }
}