using System;

namespace exercise_47
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Where do you want to go?");
      int end = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Where do you want to start from?");
      int start = Convert.ToInt32(Console.ReadLine());

      for (int i = start; i <= end; i++)
      {
        Console.WriteLine(i);
      }
    }
  }
}
