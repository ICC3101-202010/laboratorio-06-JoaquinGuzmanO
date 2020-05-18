using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace lab6
{
    [Serializable]
    class Division
    {
        protected string name;
        protected Person manager;
        protected List<Person> employees = new List<Person>();
        public Division(string name, Person manager, List<Person> employees)
        {
            this.name = name;
            this.manager = manager;
            this.employees = employees;
        }     
        public string GetName()
        {
            return name;
        }
        public string GetManager()
        {
            return manager.GetName();
        }
        public void GetEmployees()
        {
            if (employees.Count != 0)
            {
                for (int i = 0; i < employees.Count; i++)
                {
                    Console.WriteLine(employees[i].GetName());
                }
            }
            else
            {
                Console.WriteLine("Esta division no cuenta con empleados");
            }        
        }
    }

}
