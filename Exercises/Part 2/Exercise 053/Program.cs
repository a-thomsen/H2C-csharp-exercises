using System;

namespace exercise_53
{
  class Program
  {
    public static void Main(String[] args)
    {
      Console.WriteLine("What do you want to divide?");
      int num = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("What do you want to divide it with?");
      int den = Convert.ToInt32(Console.ReadLine());

      // Call your method here:
      Console.WriteLine("The result is " + Division(num, den));
    }

    // Write your method here:
    public static void Division(int num, int den)
    {
      Console.WriteLine(Convert.ToDouble(num / den));
    }
  }
}
