using System;

namespace exercise_35
{
  class Program
  {
    public static void Main(string[] args)
    {
      while (true) 
      {
        Console.WriteLine("Input an integer, 42 quits");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number == 42) 
        {
          break;
        }
      }  
    }
  }
}
