using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using Models.Interfaces;

namespace Models
{
    public class Student : User, IStudent
    {
        public List<int> Grades { get; set; } = new List<int>();
        public Student(int id, string name, string username, string pass, List<int> grades)
            : base(id, name, username, pass)
        {
            Grades = grades;
        }
        public override void PrintUser()
        {
            Console.WriteLine($"Student: {Name} with username {Username} has average {Grades.Average()} grade.");
        }

    }
}