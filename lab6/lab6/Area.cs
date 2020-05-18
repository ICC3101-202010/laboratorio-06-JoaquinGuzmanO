using System;
using System.Collections.Generic;
using System.Text;

namespace lab6
{

    class Area : Division
    {
        public Area(string name, Person manager, List<Person> employees) : base(name, manager, employees)
        {
        }
    }
}
