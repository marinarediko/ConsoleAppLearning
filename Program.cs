using System;

namespace ConsoleAppLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            Human person;
            person = new Human();
            //Console.WriteLine("Enter your name");
            //person.Name = Console.ReadLine();
            person.Name = "Jinny";
            person.Surname = "Allrey";
            person.Age = 36;
            person.EyeColor = "Blue";
            person.Introduce();

            person.Name = "Anna";
            person.Introduce();

            Human person1 = new Human("Marina", "Rediko");
            Console.WriteLine("Hello, {0}", person1.Name);
            
        }
    }
}
