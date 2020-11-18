using System;
using System.Collections.Generic;

namespace exercise_85
{
  class Program
  {
    public static void Main(string[] args)
    {
      string name = "alex emma";
      string password = "sunshine haskell";
      string[] pieces = text.Split(" ");

      Console.WriteLine("Enter username");
      string user = Console.ReadLine();
      Console.WriteLine("Enter password");
      string code = Console.ReadLine();

      if (name[0] == user && password[0] == code)
      {
        Console.WriteLine("You have successfully logged in!");
      }
      else if (name[1] == user && password[1] == code)
      {
        Console.WriteLine("You have successfully logged in!");
      }
      else
      {
        Console.WriteLine("Incorrect username or password!");
      }
    }
  }
}

