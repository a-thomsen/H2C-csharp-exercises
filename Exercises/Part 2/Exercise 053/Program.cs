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
      Division(num, den);
      double div = Convert.ToDouble(Division);
      Console.PrintLine("The result is " + div);
    }

    // Write your method here:
    public static void Division(int num, int den)
    {
      int num = 1;
      int den = 2;
      int sum = num / den;

      double div = Convert.ToDouble(sum);
    }
  }
}
