using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class EmployeeDeserialization
    {

        public string ReadJsonFile(string JsonfilePath)

        {

            string json = string.Empty;

            using (StreamReader r = new StreamReader(@"F:\Data.json"))

            {

                json = r.ReadToEnd();

                dynamic array = JsonConvert.DeserializeObject(json);

                //... read text from json file

            }

            return json;

        }
        static void Main(string[] args)
        {
            string path = @"F:\Data.json";
            EmployeeDeserialization employeeDataDeser = new EmployeeDeserialization();
            Console.WriteLine(employeeDataDeser.ReadJsonFile(path));
            Console.ReadLine();

        }
    }
}
