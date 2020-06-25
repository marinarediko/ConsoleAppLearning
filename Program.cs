using System;
using System.Collections.Generic;

namespace ConsoleAppLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Human> persons = new List<Human>();
            persons.Add(new Human( "Anna", "Orteni", 18, "Blue"));
            persons.Add(new Human("Inna", "Golka", 42, "Blue"));
            persons.Add(new Human("Jim", "Cooper", 15, "Blue"));
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

            //create some bank accounts

            List<BankAccount> accounts = new List<BankAccount>();
            accounts.Add(new BankAccount("Anna", 498, "EUR"));
            accounts.Add(new BankAccount("Inna", 3478, "EUR"));
            accounts.Add(new BankAccount("Jim", 80, "EUR"));

            foreach (var account in accounts )
            {
                account.PrintInfo();
            }

            //make some transactions on Annas acc
            accounts[0].MakeDeposit(100, "Birth gift");
            accounts[0].MakeDeposit(400, "First salary");
            accounts[0].MakeDeposit(2, "Just found");
            Console.WriteLine(accounts[0].Balance);
            accounts[0].MakeWithdrawal(140, "Airphones");
            Console.WriteLine(accounts[0].Balance);

        }
    }
}
