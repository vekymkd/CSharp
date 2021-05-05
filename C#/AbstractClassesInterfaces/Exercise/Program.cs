using System;
using System.Collections.Generic;
using Models;
using Models.Interfaces;


namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(1, "Velimir Stojanov", "velimir", "velimir123", new List<int>() {8,7,9});
            student.PrintUser();
           
            Teacher teacher = new Teacher(2, "Risto Panchevski", "risto", "test123", new List<string>() { "C#", "SQL", "MVC" });
            teacher.PrintUser();

            Console.ReadLine();
        }
    }
}
