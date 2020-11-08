using System;

namespace exercise_46
{
  class Program
  {
    public static void Main(string[] args)
    {

      int start = Convert.ToInt32(Console.ReadLine());
      int end = 100;

      for (int i = start; i <= end; i++)
      {
        Console.WriteLine(i);
      }
    }
  }
}
