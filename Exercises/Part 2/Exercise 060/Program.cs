using System;

namespace exercise_60
{
  class Program
  {
        public static void Main(String[] args)
    {
        int number = Convert.ToInt32(Console.ReadLine());
        PrintStars(number);

        int size = Convert.ToInt32(Console.ReadLine());
        PrintSquare(size);

        int width = Convert.ToInt32(Console.ReadLine());
        int height = Convert.ToInt32(Console.ReadLine());
        PrintRectangle(width, height);

        PrintTriangle(size);
    }


    public static void PrintStars(int number)
    {
      for(int i = 0; i <= number; i++)
      {
        Console.Write("*");
      }
      Console.WriteLine("");
    }

    public static void PrintSquare(int size)
    {
      for (int i = 0; i <= size; i++)
      {
        for (int x = 0; x <= size; x++)
        {
          Console.Write("*");
        }
        Console.WriteLine("");
      }
    }

    public static void PrintRectangle(int width, int height)
    {
      for (int i = 0; i <= height; i++)
      {
        for (int x = 0; x <= width; x++)
        {
          Console.Write("*");
        }
        Console.WriteLine("");  
      }
    }

    public static void PrintTriangle(int size)
    {
      for (int i = 1; i <= size; i++)
      {
        for (int x = 1; x <= i; x++)
        {
          Console.Write("*");
        }
        Console.WriteLine("");  
      }
    }
  }
}
