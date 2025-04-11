using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2251.Week3
{
    internal class PersonNotification : INotification<Person>
    {
        public void Show(Person person)
        {
            Console.WriteLine($"{person.Name} - {person.Dni}");
        }
    }
}
