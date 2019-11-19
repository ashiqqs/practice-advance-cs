﻿using System;

namespace PracticeAdvanceCS
{
    //Overriding
    /*
    Overriding Build in method like toStirng(), Equals(), GetHashCode()
        */
    class Program
    {
        public static void Main(string[] args)
        {
            Student student = new Student() {Id=1, Name="Ashiq", Roll=25 };
            Console.WriteLine(student.ToString());

            Student student2 = new Student { Id = 1, Name = "Ashiq", Roll = 25 };
            Console.WriteLine(student == student2);
            Console.WriteLine(student.Equals(student2));
            Console.WriteLine(student.GetHashCode());
            Console.ReadKey();
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Roll { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Roll: {Roll}";
        }
        public override bool Equals(object obj)
        {
            if (obj == null) { return false; }
            if(!(obj is Student)) { return false; }
            return (Id == ((Student)obj).Id
                && Roll == ((Student)obj).Roll
                && Name == ((Student)obj).Name);
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode() ^ Name.GetHashCode() ^ Roll.GetHashCode();
        }

    }

}
