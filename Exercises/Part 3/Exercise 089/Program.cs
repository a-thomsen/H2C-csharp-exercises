using System;
using System.Collections.Generic;

namespace exercise_89
{
  class Program
  {
    public static void Main(string[] args)
    {
      while (true)
      {
        Console.WriteLine("Give a string");
        string input = Console.ReadLine();

        if(input != "")
        {
          string[] pieces = input.Split(" ");
          Console.Write(pieces[pieces.Length - 1]);
        }  
      }
    }
  }
}