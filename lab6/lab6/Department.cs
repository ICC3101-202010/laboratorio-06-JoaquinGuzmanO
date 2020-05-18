using System;
using System.Collections.Generic;
using System.Text;

namespace lab6
{
    [Serializable]
    class Department : Division
    {
        public Department(string name, Person manager, List<Person> employees) : base(name, manager, employees)
        {
        }
    }
}
