using System;

namespace exercise_31
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give a number");
      string input = Console.ReadLine();
      int number = Convert.ToInt32(input);
      if ((number % 2) == 0) 
      {
        System.out.println("The number is even.");
      } 
      else 
      {
        System.out.println("The number is odd.");
      }
    }
  }
}
