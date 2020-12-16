using System;

namespace exercise_115
{
  class Program
  {
    public static void Main(string[] args)
    {
      int count = 0; 

      while (true) {
        string line = Console.ReadLine();

            if (line == "end") {
            break;
            }

        int number = Convert.ToInt32(line);
        Console.WriteLine(number * number * number);
      }
    }
  }
}