using System;

namespace exercise_21
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give me a number!");
      string firstStr = Console.ReadLine();
      int first = Convert.ToInt32(firstStr);
      Console.WriteLine("Give me another number!");
      string secondStr = Console.ReadLine();
      int second = Convert.ToInt32(secondStr);
      double average = (first + second) / 2.0;
      Console.WriteLine("The average is " + average); 
    }
  }
}
