using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2251.Week3
{
    internal class Person
    {
        private string name;
        private string dni;

        public string Name { get { return name; } }
        public string Dni { get { return dni; } }

        public Person(string name, string dni)
        {
            this.name = name;
            this.dni = dni;
        }
    }
}
