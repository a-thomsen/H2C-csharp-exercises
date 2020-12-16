using System;
using System.IO;

namespace exercise_117
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Which file should have its contents printed?");
      string input = Console.ReadLine();

      Console.WriteLine(File.ReadAllText(""" + input + """);
    }
  }
}
