using System;

namespace exercise_48
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Write numbers: ");
      int sum = 0;
      int amount = 0;
      int even = 0;
      int odd = 0; 
      double average = Convert.ToDouble(sum / amount);

      while(true)
      {
        int number = Convert.ToInt32(Console.ReadLine());

        if (number == -1)
        {
          break;
          Console.WriteLine("Thx! Bye!"); 
        }
        if ((number % 2) == 0)
        {
          even++;
          continue;
        }
        else
        {
          odd++;
          continue;
        }

      sum += number;   
      amount++;
      }
     Console.WriteLine("The sum of the numbers is " + sum +"\n"+
     "The total of numbers typed was " + amount + " and the average of them " + average +"\n"+
     "Out of the numbers " + even + " were even, and " + odd + " were odd.");
    }
  }
}
