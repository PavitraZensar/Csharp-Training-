using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoproperty_and_enhancements
{
    class Employee
    {
        public string EmpName { get; } = "Seeta";
        public double Salary { get; } = 50000.0; 

        public string Name { get; set; } = "Vijaya";
        public string Name1 { get; private set; }

        public string Companyname { get; protected set; } = "Zensar";
        public Employee()
        {
            // EmpName = "Akshay";
            Companyname = "New Zensar";
            Console.WriteLine(EmpName + " " + Salary);
        }
    }
    class AutoPropertyEg : Employee
    {
        static void Main()
        {
            Employee employee = new Employee();
            employee.Name = "Tejasree";
            Console.WriteLine(employee.Name1 + " " + employee.Companyname);

            AutoPropertyEg ape = new AutoPropertyEg();
            ape.Companyname = "Zensar P. Ltd.";
           
            Dictionary<string, string> empdict = new Dictionary<string, string>()
            {   {"Shiva","E012" },
                {"Parvathi","E024" },
                {"Ram","E026" },
                {"Rukmini ","E028" }
            };

      
            Dictionary<string, string> mydict = new Dictionary<string, string>()
            {
                ["Padma"] = "E100",
                ["Suchi"] = "E231",
                ["Hari"]  = "E002",
            };

            Console.WriteLine(@"Dictionary Initializers in C# 6.0\n\n
                                  List of Employees\n
                             -----------------------------");
            foreach (KeyValuePair<string, string> kvp in mydict)
            {
                Console.WriteLine($"Name : {kvp.Key} and EmpId : {kvp.Value}");
            }

            Console.Read();
        }
    }
}
