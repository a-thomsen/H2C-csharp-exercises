using System;
using System.Collections.Generic;

namespace exercise_110
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<Item> items = new List<Item>();

      while (true)
      {
        Console.Write("Enter a name, empty will stop: ");
        String name = Console.ReadLine();
          if (name == ""){
            break;
          } 
          else {
            items.Add(new Item(name));
          }
      }  
        
      for(int i < 0; i < items.Count; i++){
        Console.WriteLine(items[i].ToString());
      }
    }
  }
}
