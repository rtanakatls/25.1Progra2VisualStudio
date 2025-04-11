using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2251.Week3
{
    internal class Week3Menu : IMenu
    {
        public void Execute()
        {
            NotificationHandler notificationHandler = new NotificationHandler();

            notificationHandler.Show(new PlayerNotification(), new Player("Pedrito cocinero",10,20));
            notificationHandler.Show(new PersonNotification(), new Person("Pedrito","12345678"));

            List<Person> people = new List<Person>();

            people.Add(new Person("Pedro", "12345678"));
            people.Add(new Person("Vilma", "98765432"));
            people.Add(new Person("Pablo", "74185296"));
            people.Add(new Person("Betty", "96385274"));

            foreach(Person person in people)
            {
                Console.WriteLine(person.Name);
            }
            Console.WriteLine(people.Count);

            Queue<Person> peopleQueue = new Queue<Person>();

            peopleQueue.Enqueue(new Person("Pedro", "12345678"));
            peopleQueue.Enqueue(new Person("Vilma", "98765432"));
            peopleQueue.Enqueue(new Person("Pablo", "74185296"));
            peopleQueue.Enqueue(new Person("Betty", "96385274"));

            Console.WriteLine(peopleQueue.Count);
            Console.WriteLine(peopleQueue.Dequeue().Name);
            Console.WriteLine(peopleQueue.Count);

            Stack<Person> peopleStack = new Stack<Person>();

            peopleStack.Push(new Person("Pedro", "12345678"));
            peopleStack.Push(new Person("Vilma", "98765432"));
            peopleStack.Push(new Person("Pablo", "74185296"));
            peopleStack.Push(new Person("Betty", "96385274"));

            Console.WriteLine(peopleStack.Count);
            Console.WriteLine(peopleStack.Pop().Name);
            Console.WriteLine(peopleStack.Count);

            Dictionary<string, string> peopleDictionary = new Dictionary<string, string>();

            peopleDictionary.Add("Pedro", "12345678");
            peopleDictionary.Add("Vilma", "98765432");
            peopleDictionary.Add("Pablo", "74185296");
            peopleDictionary.Add("Betty", "96385274");

            Console.WriteLine(peopleDictionary["Vilma"]);

            Dictionary<string, Dictionary<int, List<Dictionary<string, List<Queue<Stack<int>>>>>>> values;

        }
    }
}
