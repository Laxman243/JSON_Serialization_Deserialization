using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp1
{
    class JsonSerialization
    {
        static void Main(string[] args)
        {
            Students e1 = new Students
            {
                FirstName = "laxman",
                LastName = "Shukla",
                Gender = "Male",
                Salary = 10000
            };
            Students e2 = new Students
            {
                FirstName = "Ved",
                LastName = "Shukla",
                Gender = "Male",
                Salary = 12000
            };
            Students e3 = new Students
            {
                FirstName = "Anita",
                LastName = "Shukla",
                Gender = "Female",
                Salary = 100
            };
            List<Students> l1 = new List<Students>();
            l1.Add(e1);
            l1.Add(e2);
            l1.Add(e3);

            string s1 = JsonConvert.SerializeObject(l1);
            Console.WriteLine(s1);

            // write json data into file 
            string path = @"Data.txt";

            // if condition if file already available then no need to create a file go to else and write all the object in jSON format
            if (File.Exists(path))
            {
                Console.WriteLine("File Created");
                File.CreateText(path);
            }
            else
            {
                File.WriteAllText(@"F:\myC#.net_Progrmas\jsonExample\Data.txt", s1);
            }
            Console.Read();

        }
    }
    class StudentDeserialized
    { 
    public string ReadJsonFile(string JsonfilePath)

    {

        string json = string.Empty;

        using (StreamReader r = new StreamReader("F:\\myC#.net_Progrmas\\jsonExample\\Data.txt"))

        {

            json = r.ReadToEnd();

            dynamic array = JsonConvert.DeserializeObject(json);

            //... read text from json file

        }

        return json;

    }
        static void Main(string[] args)
        {
            string path = @"F:\myC#.net_Progrmas\jsonExample\Data.txt";
            //  EmployeeDeserialization employeeDataDeser = new EmployeeDeserialization();
            // Console.WriteLine(employeeDataDeser.ReadJsonFile(path));
            StudentDeserialized StudentData = new StudentDeserialized();
            Console.WriteLine(StudentData.ReadJsonFile(path));
            Console.ReadLine();
        }

    }
}
