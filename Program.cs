﻿using PracticeAdvanceCS.EmployeePart;
using System;
using System.Text;

namespace PracticeAdvanceCS
{
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
