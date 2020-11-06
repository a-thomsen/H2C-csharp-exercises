using System;

namespace exercise_40
{
  class Program
  {
    public static void Main(string[] args)
    {
      int sum = 0;
      int amount = 0;
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
            amount = amount + 1;
        }
      }
      Console.WriteLine("Total sum of numbers: " + sum +"\n"
      "Total amount of numbers: " + amount);      
    }
  }
}
