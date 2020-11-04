using System;

namespace exercise_24
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.Write("What's your speed?");
      string input = Console.ReadLine();
      int speed = Convert.ToInt32(input);
      if (speed > 120) 
      {
        Console.WriteLine("Speeding!");
      }
    }
  }
}
