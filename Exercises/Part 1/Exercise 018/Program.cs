using System;

namespace exercise_18
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
      Console.WriteLine("Now give me one more number!");
      string thirdStr = Console.ReadLine();
      int third = Convert.ToInt32(thirdStr);
      Console.WriteLine("The sum of these numbers is " + (first + second + third));

    }
  }
}
