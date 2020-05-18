using System;
using System.Collections.Generic;


namespace lab6
{
    [Serializable]
    class Company
    {
        private string name;
        private string rut;
        private List<Division> divisions; //area,departamento,seccion,bloque
        public Company(string name, string rut, List<Division> divisions)
        {
            this.name = name;
            this.rut = rut;
            this.divisions = divisions;
        }

        public void Info1()
        {
            Console.WriteLine("Se creo la siguiente empresa");
            Console.WriteLine("nombre: "+name+"\nrut: "+rut);
            Console.WriteLine("Con las siguientes divisiones:");
            Console.WriteLine("Departamento: " + divisions[0].GetName() + "\nSu encargado es: "+divisions[0].GetManager()+"\nSus empleados son: ");
            divisions[0].GetEmployees();
            Console.WriteLine("Seccion: " + divisions[1].GetName() + "\nSu encargado es: " + divisions[1].GetManager() + "\nSus empleados son: ");
            divisions[1].GetEmployees();
            Console.WriteLine("Bloque 1: " + divisions[2].GetName() + "\nSu encargado es: " + divisions[2].GetManager() + "\nSus empleados son: ");
            divisions[2].GetEmployees();
            Console.WriteLine("Bloque 2: " + divisions[3].GetName() + "\nSu encargado es: " + divisions[3].GetManager() + "\nSus empleados son: ");
            divisions[3].GetEmployees();
        }
        public void Info2()
        {
            Console.WriteLine("Se creo la siguiente empresa");
            Console.WriteLine("nombre: " + name + "\nrut: " + rut);
            Console.WriteLine("Con las siguientes divisiones:");
            Console.WriteLine("Area: " + divisions[0].GetName() + "\nSu encargado es: " + divisions[0].GetManager() + "\nSus empleados son: ");
            divisions[0].GetEmployees();
            Console.WriteLine("Departamento: " + divisions[1].GetName() + "\nSu encargado es: " + divisions[1].GetManager() + "\nSus empleados son: ");
            divisions[1].GetEmployees();
            Console.WriteLine("Seccion: " + divisions[2].GetName() + "\nSu encargado es: " + divisions[2].GetManager() + "\nSus empleados son: ");
            divisions[2].GetEmployees();
            Console.WriteLine("Bloque: " + divisions[3].GetName() + "\nSu encargado es: " + divisions[3].GetManager() + "\nSus empleados son: ");
            divisions[3].GetEmployees();
        }
    }
}
