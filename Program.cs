using System;

namespace ConsoleAppLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            Human person;
            person = new Human( "Marina", "Rediko", 18 , "Blue");
            person.Introduce();

            person.AddNumbers(person.Age , 34);

            Human person1 = new Human("Marina", "Rediko");
            Console.WriteLine("Hello, {0}", person1.Name);
            
        }
    }
}
