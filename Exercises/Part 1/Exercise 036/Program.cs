using System;

namespace exercise_36
{
  class Program
  {
    public static void Main(string[] args)
    {
      while (true) 
      {
        Console.WriteLine("Type in a number, 0 quits");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number == 0) 
        {
          break;
        }
        if  (number < 0)
        {
          Console.WriteLine("That is a negative");
          continue;
        }
      Console.WriteLine("Your number raised in its second power is " + (number * number));
      }
    }
  }
}
