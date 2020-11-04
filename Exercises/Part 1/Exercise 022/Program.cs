using System;

namespace exercise_22
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
      Console.WriteLine("Give me one more number!");
      string thirdStr = Console.ReadLine();
      int third = Convert.ToInt32(thirdStr);
      double average = (first + second + third) / 3.0;
      Console.WriteLine("The average is " + average); 
    }
  }
}
