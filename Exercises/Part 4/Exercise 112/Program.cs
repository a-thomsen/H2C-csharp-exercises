using System;
using System.Collections.Generic;

namespace exercise_112
{
  class Program
  {
    public static void Main(string[] args)
    {
      // IMPLEMENT YOUR CODE IN HERE!

      List<TelevisionProgram> programs = new List<TelevisionProgram>();
      
      while (true)
      {
        Console.WriteLine("Enter a TV program");
        string name = Console.ReadLine();
          if (name == "")
          {
            break;
          }

        Console.Write("Enter the duration of " + name);
        int duration = Convert.ToInt32(Console.ReadLine());

        programs.Add(new TelevisionProgram(name, duration)); 
      }

      Console.WriteLine(); 
      Console.WriteLine("Enter the maximum duration of the program");
      int maxLimit = Convert.ToInt32(Console.ReadLine()); 

      for (int i = 0; i < programs.Count; i++) {
        
        if (programs[i].duration <= maxLimit) {
          Console.WriteLine(programs[i].ToString()); 
        }
      }
    }
  }  
}  