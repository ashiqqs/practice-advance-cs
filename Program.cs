﻿using PracticeAdvanceCS.EmployeePart;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace PracticeAdvanceCS
{
    //Usefull methods for List
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Student> students = new List<Student>(10){
                new Student{Id=1013, Name="Mark", DueFee=2500},
                new Student{Id=1320, Name="Alex", DueFee=1900},
                new Student{Id=1231, Name="Sam", DueFee = 2800},
                new Student{Id=1020, Name="David", DueFee=1200},
                new Student{Id=1102, Name="Jay Setty", DueFee=1500},
            };

            //return true if all the element matches the condition otherwise false
            bool isDueAllGreaterTwoThousend = students.TrueForAll(s => s.DueFee > 2000);

            //Disable a list to write/remove an element
            ReadOnlyCollection<Student> readOnlyStudents = students.AsReadOnly();

            //Set a list to actual Capacity
            Console.WriteLine(students.Capacity);
            students.TrimExcess();
            Console.WriteLine(students.Capacity);

            Console.ReadKey();
        }
    }

    //Creating A complex type as Sortable
    public class Student : IComparable<Student>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DueFee { get; set; }

        public int CompareTo(Student other)
        {
            return this.Name.CompareTo(other.Name);
        }
        public static int SortById(Student s1, Student s2)
        {
            return s1.Id.CompareTo(s2.Id);
        }
    }

    //Creating Custom Sort field
    public class SortByDueFee : IComparer<Student>
    {
        public int Compare(Student s1, Student s2)
        {
            if (s1.DueFee > s2.DueFee) return 1;
            else if (s1.DueFee < s2.DueFee) return -1;
            else return 0;
        }
    }
}
