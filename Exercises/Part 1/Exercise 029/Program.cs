using System;

namespace exercise_29
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give a number ");
      string firstInput = Console.ReadLine();
      int first = Convert.ToInt32(firstInput);
      Console.WriteLine("Give another number ");
      string secondInput = Console.ReadLine();
      int second = Convert.ToInt32(secondInput);
      

      if (first > second) 
      {
        Console.WriteLine("The larger number is " + first + "!");
      }
      else if (first < second) 
      {
        Console.WriteLine("The larger number is " + second + "!");
      } 
      else
      {
        Console.WriteLine("The numbers are equal!");
      }
    }
  }
}
