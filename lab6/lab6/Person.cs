using System;
using System.Collections.Generic;
using System.Text;

namespace lab6
{
    [Serializable]
    class Person
    {
        private string name;
        private string lastname;
        private string rut;
        private string position;
        public Person(string name, string lastname, string rut, string position)
        {
            this.name = name;
            this.lastname = lastname;
            this.rut = rut;
            this.position = position;
        }
        public string GetName()
        {
            return name;
        }
    }
}
