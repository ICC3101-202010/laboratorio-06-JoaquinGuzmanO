using System;
using System.Collections.Generic;
using System.Text;

namespace lab6
{
    [Serializable]
    class Block : Division
    {
        public Block(string name,Person manager, List<Person> employees) : base(name,manager,employees)
        {
        }
    }
}
