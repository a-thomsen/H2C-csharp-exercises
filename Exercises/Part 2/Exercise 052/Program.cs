using System;

namespace exercise_52
{
  class Program
  {
    public static void Main(String[] args)
    {
      Console.WriteLine("Give me a number and I'll do the counting!");
      int max = Convert.ToInt32(Console.ReadLine());
      // Call your method here:
      PrintFromNumberToOne(max);
    }

    // Write your method here:
    public static void PrintFromNumberToOne (int max)
    {
      int min = 1;
      while (min < max) 
      {
          Console.WriteLine(max);
          max--;
      }
    }  
  }
}
