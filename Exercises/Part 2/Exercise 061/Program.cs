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
        for (int x = 1; x <= size-i; x++)
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
      for (int i = 1; i <= height; i++)
      {
        for (int y = height-i; y >= 0; y--)
        {
          PrintSpaces(0);
        }
        for (int x = 1+(i-1)*2; x > 0; x--)
        {
          PrintStars(0);
        }
        Console.WriteLine("");
      }

      for (int z = 0; z <= 1; z++)
      {
        for (int a = 0; a <= height-2; a++)
        {
          Console.Write(" ");
        }
        Console.WriteLine("***");
      }
    }
  }
}
// NTS: Check the assignment fully, such a maze...