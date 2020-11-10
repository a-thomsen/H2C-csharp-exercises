using System;

namespace exercise_61
{
  class Program
  {
    public static void Main(String[] args)
    {
      int number = Convert.ToInt32(Console.ReadLine());

    }

    public static void PrintStars(int number)
    {
      for(int i = 0; i <= number; i++)
      {
        Console.Write("*");
      }
      Console.WriteLine("");
    }

    public static void PrintSpaces(int number)
    {
      for (int i = 0; i <= number; i++)
      {
        Console.Write(" ");
      }
    }

    public static void PrintRightTriangle(int size)
    {
      for (int i = 1; i <= size; i++)
      {
        for (int x = 1; x <= i; x++)
        {
          Console.Write(" ");
        }
        for (int y = 1; y <= i; y++)
        {
          Console.Write("*");
        }
        Console.WriteLine("");
      }
    }

    public static void ChristmasTree(int height)
    {
      for (int i = 0; i <= height; i++)
      {
        // Continue from here
      }
    }
  }
}
