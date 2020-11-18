using System;
using System.Collections.Generic;

namespace exercise_83
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give a word");
      string word = Console.ReadLine();

      // Can be done with while-loop as well, check below
      Console.Write(word+word+word);

    }

  }
}

// While-loop option:
// int repeat = 0;
// while (repeat < 3){
// Console.Write(word);
// repeat++; }
