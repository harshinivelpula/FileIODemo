using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FileIODemo
{
    internal class BinarySerialization
    {
        public void Seralization()
        {
            Demo Sample = new Demo();
            FileStream fileStream = new FileStream(@"C:\Users\DELL\source\repos\FileIODemo\FileIODemo\Demo.txt", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, Sample);

        }

        public void DeSeralization()
        {
            Demo Sample = new Demo();
            FileStream fileStream = new FileStream(@"C:\Users\DELL\source\repos\FileIODemo\FileIODemo\Demo.txt", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            Demo deserializationsampledemo = (Demo)formatter.Deserialize(fileStream);
            Console.WriteLine("ApllicationName:" + deserializationsampledemo + "ApplicationID:" + deserializationsampledemo.ApplicationId);

        }


        [Serializable]
        public class Demo
        {
            public string ApplicationName { get; set; } = "Binary Serialize";
            public int ApplicationId { get; set; } = 1001;
        }
    }
}
