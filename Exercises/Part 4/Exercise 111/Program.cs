using System;
using System.Collections.Generic;

namespace exercise_111
{
  class Program
  {
    public static void Main(string[] args)
    {
      // IMPLEMENT YOUR CODE IN HERE!
      List<PersonalInformation> list = new List<PersonalInformation>();

      while(true){

        Console.Write("Enter your first name, last name and identification number separated with a comma");
        string details = Console.ReadLine(); 

        if (details == ""){
          break; 
        }

        string[]parts = details.Split(",");
        string firstName = parts[0];
        string lastName = parts[1];
        int idNumber = Convert.ToInt32(parts[2]);

        list.Add(new PersonalInformation(firstName, lastName, idNumber)); 
      }

      Console.WriteLine();

      foreach (PersonalInformation personalInformation in list) {
      Console.WriteLine(personalInformation.firstName + " " + personalInformation.lastName);
      }
    }
  }
}




