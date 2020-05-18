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
            List<Company> person_l = new List<Company>();
            Console.WriteLine("¿Quiere utilizar un archivo para cargar la información de la empresa?[si],[no]");
            string answer = Console.ReadLine();

            if(answer == "no")
            {
                Console.WriteLine("diga el nombre de la empresa:");
                string name = Console.ReadLine();
                Console.WriteLine("diga el rut de la empresa:");
                string rut = Console.ReadLine();
                Company company = new Company(name, rut);

                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("empresa.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, company);
                company.Info();
                stream.Close();
            }
            if(answer == "si")
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("empresa.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                Company company = (Company)formatter.Deserialize(stream);
                company.Info();
                stream.Close();
            }








        }
    }
}
