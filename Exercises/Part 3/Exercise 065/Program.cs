﻿using System;
using System.Collections.Generic;

namespace exercise_65
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<string> list = new List<string>();
      while (true)
      {
        string input = Console.ReadLine();
        if (input == "")
        {
          break;
        }
        list.Add(input);
      }
      Console.WriteLine("The number of the values on the list is " + list.Count);
    }
  }
}
