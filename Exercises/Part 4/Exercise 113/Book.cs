using System;

namespace exercise_113
{
  public class Book {
      public string name { get; set; }
      public int pages { get; set; } 
      public int year { get; set; }

  public Book (string name){
      this.pages = pages;
      this.year = year; 
      this.name = name;
    }

  public override string ToString()
    {
        return this.name + ", " + this.pages + " pages, " + this.year;
    }  
  }
}