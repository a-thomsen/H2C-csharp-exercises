using System;

namespace exercise_30
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Fill in your grading percentage");
      string input = Console.ReadLine();
      int grade = Convert.ToInt32(input);
      if (grade < 0) 
      {
        Console.WriteLine("Impossible!");
      }
      else if (grade <= 49) 
      {
        Console.WriteLine("Fail");
      }   
      else if (grade <= 59) 
      {
        Console.WriteLine("Grade is: 1");
      } 
      else if (grade <= 69) 
      {
        Console.WriteLine("Grade is: 2");
      } 
      else if (grade <= 79) 
      {
        Console.WriteLine("Grade is: 3");
      } 
      else if (grade <= 89) 
      {
        Console.WriteLine("Grade is: 4");
      } 
      else if (grade <= 100) 
      {
        Console.WriteLine("Grade is: 5");
      }
      else
      {
        Console.WriteLine("Outstanding!");
      }
    }
  }
}
