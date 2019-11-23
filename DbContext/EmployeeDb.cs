using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAdvanceCS.EmployeePart
{
    public delegate bool SeniorChecker(Employee employee);
    public partial class Employee
    {
        public Employee(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public Employee()
        {
        }
        public void GetEmpBasicInfo()
        {
           Console.Write($"Id: {this.Id}, Name: {this.Name}");
        }
        public static void GetFilteredEmployee(List<Employee> employess, SeniorChecker seniorChecker)
        {
            foreach (Employee emp in employess)
            {
                if (seniorChecker(emp))
                {
                    Console.WriteLine($"Name:{emp.Name}Experience: {emp.Experience} Salary: {emp.Salary}");
                }
            }
        }
    }
}
