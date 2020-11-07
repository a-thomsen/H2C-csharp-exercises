using System;

namespace exercise_41
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Hit me with a number!");
      int number = Convert.ToInt32(Console.ReadLine());

      int result = number * number;

      Console.WriteLine("Your number in its second power is " + result);
    }
  }
}
