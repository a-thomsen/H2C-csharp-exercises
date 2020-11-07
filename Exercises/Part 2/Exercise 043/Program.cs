using System;

namespace exercise_43
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Hit me with a number!");
      int input = Convert.ToInt32(Console.ReadLine());

      if (input < 0)
      {
        Console.WriteLine(input * -1);
      }
      else
      {
        Console.WriteLine(input);
      }
    }
  }
}
