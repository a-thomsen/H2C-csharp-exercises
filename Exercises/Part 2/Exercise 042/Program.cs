using System;

namespace exercise_42
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("Hit me with a number!");
      int first = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Hit me with another number!");
      int second = Convert.ToInt32(Console.ReadLine());

      int sum = first + second;

      double sqRoot = Math.Sqrt(sum);

      Console.WriteLine("The square root of the sum of your inputs is " + sqRoot);
    }
  }
}
