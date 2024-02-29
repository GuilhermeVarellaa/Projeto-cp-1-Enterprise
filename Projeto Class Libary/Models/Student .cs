using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Class_Libary.Models
{
    public class Student
    {
        
        public string Name { get; set; }
        public int Age { get; set; }
        public string StudentId { get; set; }
        public List<double> Grades { get; private set; }

        
        public Student(string name, int age, string studentId)
        {
            Name = name;
            Age = age;
            StudentId = studentId;
            Grades = new List<double>();
        }

        public Student(string name, int age) : this(name, age, GenerateStudentId())
        {
        }

        public Student() : this("Unknown", 0)
        {
        }

     
        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Student ID: {StudentId}";
        }

   
        public void AddGrade(double grade)
        {
            Grades.Add(grade);
        }

        
        public double CalculateAverageGrade()
        {
            if (Grades.Count == 0)
                return 0;

            double sum = 0;
            foreach (var grade in Grades)
            {
                sum += grade;
            }
            return sum / Grades.Count;
        }

    
        private static string GenerateStudentId()
        {
            return Guid.NewGuid().ToString();
        }

        private void PrivateMethod()
        {
            Console.WriteLine("pera");
        }
    }
}