﻿using PracticeAdvanceCS.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAdvanceCS
{
    //Enum
    class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee{Name = "Mark",Gender = Gender.Male},
                new Employee{Name = "Mery",Gender = Gender.Female},
                new Employee{Name = "Sam",Gender = Gender.Unknown}
            };

            foreach(var emp in employees)
            {
                Console.WriteLine($"Name {emp.Name}, Gender: {emp.Gender}, GenderId: {(int)emp.Gender}");
            }
            Console.ReadKey();
        }
    }
    public class Employee
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
    }

    public enum Gender
    {
        Male=1,
        Female=2,
        Unknown=0
    }
}
