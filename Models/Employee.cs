using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAdvanceCS.Models
{
    public delegate bool SeniorChecker(Employee employee);
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

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
