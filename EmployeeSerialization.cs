using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
namespace JSONAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            // used List to add JSON OBjects 
            List<Employee> lstemployee = new List<Employee>();
            lstemployee.Add(new Employee()
            {
                EmployeeID = 100,
                EmployeeName = "Pradeep",
                DeptWorking = "OnLineBanking",
                Salary = 10000
            });
            lstemployee.Add(new Employee()
            {
                EmployeeID = 101,
                EmployeeName = "Mark",
                DeptWorking = "OnLineBanking",
                Salary = 20000
            });
            lstemployee.Add(new Employee()
            {
                EmployeeID = 102,
                EmployeeName = "Smith",
                DeptWorking = "Mobile banking",
                Salary = 10000
            });
            lstemployee.Add(new Employee()
            {
                EmployeeID = 103,
                EmployeeName = "John",
                DeptWorking = "Testing",
                Salary = 7000
            });

            // Now JsonConvert is converting C# type to JSON type
            string output = JsonConvert.SerializeObject(lstemployee.ToArray());
            Console.WriteLine("Serialization output");
            Console.WriteLine(output);

            string path = @"abc.txt";

            // if condition if file already available then no need to create a file go to else and write all the object in jSON format
            if (File.Exists(path))
            {
                Console.WriteLine("File Created");
                File.CreateText(path);
            }
            else
            {
                File.WriteAllText(@"F:\myC#.net_Progrmas\jsonExample\abc.txt", output);
            }
            // go to file and check the JSON data
            Console.WriteLine("==================================");
            Console.WriteLine("Deserialization");
             var Details = JsonConvert.DeserializeObject<Employee[]>(output);
            Console.WriteLine(Details);
            Console.WriteLine("Reading All Values");
             foreach(var x in Details)
            {
                Console.WriteLine("Employee ID :  {0}", x.EmployeeID.ToString());
                Console.WriteLine("Employee Salary : {0}", x.Salary.ToString());
                Console.WriteLine("Employee Dept : {0}", x.DeptWorking.ToString());
                Console.WriteLine("Employee Name : {0}", x.EmployeeName.ToString());
            }
            Console.Read();
        }
    }
}