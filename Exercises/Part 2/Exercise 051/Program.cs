using System;

namespace exercise_51
{
  class Program
  {
    public static void Main(String[] args)
    {
      Console.WriteLine("Give me a number and I'll do the counting!");
      int max = Convert.ToInt32(Console.ReadLine());
      // Call your method here:
      PrintUntilNumber(max);
    }

    // Write your method here:
    public static void PrintUntilNumber (int max)
    {
      int min = 1;
      while (min < max) 
      {
          Console.WriteLine(min);
          min++;
      }
    }  
  }
}
