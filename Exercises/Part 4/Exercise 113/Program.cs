using System;
using System.Collections.Generic;

namespace exercise_113
{
  class Program
  {
    public static void Main(string[] args)
    {
      // IMPLEMENT YOUR CODE IN HERE!
      // Remember also to create the file Book.cs and class in it!

    List<Book> books = new List<Book>();

    while(true){

        Console.Write("Enter the title of the book, number of pages and the year it was published separated with a comma");
        string details = Console.ReadLine(); 

          if (details == ""){
            break; 
          }

        string[]parts = details.Split(",");
        string title = parts[0];
        int pages  = Convert.ToInt32(parts[1]);
        int year = Convert.ToInt32(parts[2]);

        books.Add(new Book(title, pages, year)); 
      }

    while(true){  

        Console.WriteLine("What do you want to print?");
        string print = Console.ReadLine(); 

          if (print == "everything"){
            for (int i = 0; i < books.Count; i++){
              Console.WriteLine(books[i].ToString());
            }
          }  
          else if (print == "title"){
            for (int i = 0; i < books.Count; i++){
              Console.WriteLine(books[i].title); 
            }
          }  
          else {
            break; 
          }
      }
    }
  }
}





