using System;

namespace exercise_54
{
  class Program
  {
    public static void Main(String[] args)
    {
      Console.WriteLine("Where do you want to start from?");
      int start = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Where do you want to end up?");
      int end = Convert.ToInt32(Console.ReadLine());

      // Call your method here:
      DivisibleByThreeInRange(start, end);

    }

    // Write your method here:
    public static void DivisibleByThreeInRange(int start, int end)
    {
      for (int i = start; i <= end; i++)
      {
        if ((i%3) == 0)
        {
          Console.WriteLine(i);
        }
      }
    }
  }
}
