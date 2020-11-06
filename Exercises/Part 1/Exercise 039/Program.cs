using System;

namespace exercise_39
{
  class Program
  {
    public static void Main(string[] args)
    {
      int sum = 0;
      while (true) 
      {
        Console.WriteLine("Give a number. With 0 you're gone for good!");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number == 0) 
        {
            break;
        }
        if  (number != 0)
        {
            sum = sum + number;
        }
      }
      Console.WriteLine("Total sum of numbers: " + sum);
    }
  }
}
