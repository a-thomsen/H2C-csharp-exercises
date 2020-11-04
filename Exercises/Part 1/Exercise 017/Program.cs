using System;

namespace exercise_17
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
      Console.WriteLine("The sum of these numbers is " + (first + second));
    }
  }
}
