using PracticeAdvanceCS.EmployeePart;
using System;
using System.Text;

namespace PracticeAdvanceCS
{
//PartialClass
//Partial class use to split a class
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee(1, "Ashiq");

            employee.GetEmpBasicInfo();
            Console.ReadKey();
        }
    }

}
