using System;
using System.Linq;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;

namespace lab6
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Division> divisions = new List<Division>();
            List<Person> DepartmentEmployees = new List<Person>();
            List<Person> SectionEmployees = new List<Person>();
            List<Person> blockEmployees1 = new List<Person>();
            List<Person> blockEmployees2 = new List<Person>();
            serializador serializador = new serializador();

            try
            {
                serializador.Deserialize();
                //cuando deserializamos suponemos que el archivo empresa.bin viene con el formato:
                // 1 Area, 1 Departamento, 1 seccion y un solo bloque, ademas que cada uno venga con
                //su encargado y lista de empleados correspondiente
            }
            catch (FileNotFoundException)
            {


                Console.WriteLine("diga el nombre de la empresa:");
                string name = Console.ReadLine();
                Console.WriteLine("diga el rut de la empresa:");
                string rut = Console.ReadLine();
                Console.Clear();

                Person managerDepartment = new Person("Camila", "Rodriguez", "8778111-9", "Encargado del departamento");
                Department department = new Department("Departamento", managerDepartment,DepartmentEmployees);
                divisions.Add(department);
                Console.Clear();

                Person managerSection = new Person("Maria Jose", "Provoste", "20160991-7", "Encargado de la seccion");
                Section section = new Section("Seccion", managerSection,SectionEmployees);
                divisions.Add(section);
                Console.Clear();

                Person managerBlock1 = new Person("Manuel", "Revecco", "19678554-3", "Encargado del bloque 1");
                Person employee1 = new Person("Horacio", "Palazuelos", "20567111-k", "Trabajador");
                Person employee2 = new Person("Pedro", "Vallejos", "3458909-2", "Trabajador");
                blockEmployees1.Add(employee1);
                blockEmployees1.Add(employee2);
                Block block1 = new Block("bloque 1", managerBlock1, blockEmployees1);
                divisions.Add(block1);
                Console.Clear();

                Person managerBlock2 = new Person("Martin", "Rodrigez", "1964444-3", "Encargado del bloque 2");
                Person employee3 = new Person("Marta", "Valenzuela", "29876211-k", "Trabajador");
                Person employee4 = new Person("Joaquin", "Avaria", "3458909-8", "Trabajador");
                blockEmployees2.Add(employee3);
                blockEmployees2.Add(employee4);
                Block block2 = new Block("bloque 2", managerBlock2, blockEmployees2);
                divisions.Add(block2);
                Console.Clear();

                Company company = new Company(name, rut, divisions);
                serializador.Serialize(company);
            }  
        }
        //                       ########### PARTE 1 ################
        //    Console.WriteLine("¿Quiere utilizar un archivo para cargar la información de la empresa?[si],[no]");
        //    string answer = Console.ReadLine();
        //    if(answer == "no")
        //    {
        //        Console.WriteLine("diga el nombre de la empresa:");
        //        string name = Console.ReadLine();
        //        Console.WriteLine("diga el rut de la empresa:");
        //        string rut = Console.ReadLine();
        //        Company company = new Company(name, rut);
        //        IFormatter formatter = new BinaryFormatter();
        //        Stream stream = new FileStream("empresa.bin", FileMode.Create, FileAccess.Write, FileShare.None);
        //        formatter.Serialize(stream, company);
        //        company.Info();
        //        stream.Close();
        //    }
        //    if(answer == "si")
        //    {
        //        try
        //        {
        //            IFormatter formatter = new BinaryFormatter();
        //            Stream stream = new FileStream("empresa.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
        //            Company company = (Company)formatter.Deserialize(stream);
        //            company.Info();
        //            stream.Close();
        //        }
        //        catch(FileNotFoundException)
        //        {
        //            Console.WriteLine("diga el nombre de la empresa:");
        //            string name = Console.ReadLine();
        //            Console.WriteLine("diga el rut de la empresa:");
        //            string rut = Console.ReadLine();
        //            Company company = new Company(name, rut);
        //            IFormatter formatter = new BinaryFormatter();
        //            Stream stream = new FileStream("empresa.bin", FileMode.Create, FileAccess.Write, FileShare.None);
        //            formatter.Serialize(stream, company);
        //            company.Info();
        //            stream.Close();
        //        }
        //    }
    }
}
