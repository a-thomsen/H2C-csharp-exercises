using System;
using System.IO;

namespace exercise_117
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Which file should have its contents printed? Insert file name inside quotation marks.");
      string input = Console.ReadLine();

      string text = File.ReadAllText(input);
      Console.WriteLine(text);
    }
  }
}
