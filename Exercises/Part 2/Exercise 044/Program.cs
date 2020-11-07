using System;

namespace exercise_44
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("Hit me with a number!");
      int first = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Hit me with another number!");
      int second = Convert.ToInt32(Console.ReadLine());

      if (first > second)
      {
        Console.WriteLine(first + " is greater than " + second);
      }
      else if (first < second)
      {
        Console.WriteLine(first + " is less than " + second);
      }
      else
      {
        Console.WriteLine(first + " is equal to " + second);
      }
    }
  }
}
