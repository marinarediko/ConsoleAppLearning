using System;
using System.Collections.Generic;

namespace ConsoleAppLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Human> persons = new List<Human>();
            persons.Add(new Human( "Marina", "Rediko", 18, "Blue"));
            persons.Add(new Human("Alicija", "Voronecka", 42, "Blue"));
            persons.Add(new Human("Kristina", "Rediko", 15, "Blue"));
            persons.Add(new Human("Yevgenijs", "Rediko", 43, "Blue"));

            /*  for (int i = 0; i < persons.Count; i++)
              {
                  persons[i].Introduce();
              }*/

            //persons[2].SetAge(8);
            //Console.WriteLine(persons[0].GetType());

            foreach(var person in persons )
            {
                person.Introduce();
            }
        }
    }
}
