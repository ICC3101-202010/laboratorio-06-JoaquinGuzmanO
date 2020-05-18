using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace lab6
{
    class serializador
    {
        public static void Serialize(Company company)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("empresa.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, company);
            company.Info1();
            stream.Close();
        }
        public static void Deserialize()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("empresa.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            Company company = (Company)formatter.Deserialize(stream);
            company.Info2();
            stream.Close();
        }
    }
}
