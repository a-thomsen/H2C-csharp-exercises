using System;

namespace exercise_10
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("I will tell a story, but I need some information.\n"
            "Give a name for main character: ");
            string name = Console.ReadLine();
            Console.WriteLine("Give the character a profession: ");
            string prof = Console.ReadLine();
            Console.WriteLine("Here is the story:\n"
            "Once upon a time there was a " + prof + " called " + name +"\n"
            "On her way to work, " + name + "often pondered what being " + prof + "meant to them.\n"
            "When you work as a" + prof + "you meet interesting people.\n"
            name + " enjoys their work as " + prof + ", The end.");
        }
    }
}
