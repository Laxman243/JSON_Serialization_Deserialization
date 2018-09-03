using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    class Person
    {
        public int PersonId { get; set;}
        public string PersonName { get; set;}
        public int Age { get; set;}
        public string Country { get; set; }
    }
    class PersonSerialized
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.PersonId = 14;
            p.PersonName = "laxman";
            p.Age = 24;
            p.Country = "India";

            string jsonTextData = JsonConvert.SerializeObject(p);
            Console.WriteLine(jsonTextData);

            // Deserialized
            Person jsonTextDataDeserialized = JsonConvert.DeserializeObject<Person>(jsonTextData);
            Console.WriteLine(jsonTextDataDeserialized);

            Console.WriteLine(p.PersonId);
            Console.WriteLine(p.PersonName);
            Console.WriteLine(p.Age);
            Console.WriteLine(p.Country);
            Console.Read();
        }
    }
}
