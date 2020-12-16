using System;
using System.IO;

namespace exercise_118
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Name of the file:");
      string file = Console.ReadLine();

      // DO NOT TOUCH THE CODE ABOVE!
      // implement reading the file here;
      List<string> names = File.ReadAllLines(file).ToList();
      
      foreach (string name in names){
        Console.WriteLine(name); 
      }

      // DO NOT TOUCH THE CODE BELOW!
      Console.WriteLine("");

      Console.WriteLine("Enter names, an empty line quits.");
      while (true)
      {
        string name = Console.ReadLine();
        if (name == "")
        {
          break;
        }

        if (names.Contains(name))
        {
          Console.WriteLine("The name is on the list.");
        }
        else
        {
          Console.WriteLine("The name is not on the list.");
        }
      }

      Console.WriteLine("Thank you!");

    }
  }
}
