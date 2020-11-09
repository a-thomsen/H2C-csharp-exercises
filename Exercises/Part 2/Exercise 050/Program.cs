using System;

namespace exercise_50
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Call your method here:
      Console.WriteLine("How many times do you want to print the phrase?");
      int answer = Convert.ToInt32(Console.ReadLine());
      int i = 0;

      while (i <= answer)
      {
        PrintPhrase();
        i++;
      }
    }

    // Write your method here:
    public static void PrintPhrase() 
    {
      Console.WriteLine("In a hole in the ground there lived a method");
    }
  }
}
