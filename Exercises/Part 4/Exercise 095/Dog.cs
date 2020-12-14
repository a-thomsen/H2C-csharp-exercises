using System;

namespace exercise_95
{
  public class Dog {

    private string name;
    private string breed;
    private int age; 

    public Dog(string name, string breed, int age) {
        this.name = name;
        this.breed = breed;
        this.age = age;
    }

    public void PrintDog() {
    Console.WriteLine(this.name + this.breed + this.age);
    }
  }
}