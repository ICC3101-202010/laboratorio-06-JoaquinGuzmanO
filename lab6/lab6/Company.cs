using System;
using System.Collections.Generic;
using System.Text;

namespace lab6
{
    [Serializable]
    class Company
    {
        private string name;
        private string rut;

        public Company(string name, string rut)
        {
            this.name = name;
            this.rut = rut;
        }
        public void Info()
        {
            Console.WriteLine("Se creo la siguiente empresa");
            Console.WriteLine("nombre: "+name+"\nrut: "+rut);
        }
    }
}
