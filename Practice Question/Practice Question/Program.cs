using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Question
{
    class ITT
    {
        public int ID { get; set; }
        public int Code { get; set; }
        public int Password { get; set; }
    }

    class Employee
    {
        public int ID { get; set; }
        public int EmployeeCode { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<ITT> ITTList = new List<ITT>();

            ITTList.Add(new ITT { Code = 1, ID = 123, Password = 11 });
            ITTList.Add(new ITT { Code = 2, ID = 456, Password = 12 });
            ITTList.Add(new ITT { Code = 3, ID = 789, Password = 13 });

            List<Employee> employees = new List<Employee>();
            
            employees.Add(new Employee { ID = 1, EmployeeCode = 1, Name = "Ronak", Number = 12345 });
            employees.Add(new Employee { ID = 2, EmployeeCode = 2, Name = "Chirag", Number = 67890 });
            employees.Add(new Employee { ID = 3, EmployeeCode = 4, Name = "Saurbh", Number = 0});

           var QuerySyntex = (from emp in employees
                             where emp.Number == 0
                             select emp);

           var matchingEmployees = from emp in employees
                                   join itt in ITTList on emp.EmployeeCode equals itt.Code
                                   select new { EmployeeName = emp.Name, ITTCode = itt.Code };

          
            Console.WriteLine("Employees and their matching ITT Codes:");
            foreach (var match in matchingEmployees)
            {
                Console.WriteLine($"Employee Name: {match.EmployeeName}, Matching ITT Code: {match.ITTCode}");
            }

            Console.WriteLine("Employees with empty Number:");
            foreach (var employee in QuerySyntex)
            {
                Console.WriteLine($"ID: {employee.ID}, Name: {employee.Name}, Number: {employee.Number}");
            }

        }
    }
}
