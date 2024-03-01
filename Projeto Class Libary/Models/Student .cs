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
        public List<double> Grades { get; private set; } = new List<double>();

        public Student(string name, int age, string studentId)
        {
            Name = name;
            Age = age;
            StudentId = studentId;
        }

        public Student(string name, int age) : this(name, age, GenerateStudentId())
        {
        }

        public Student() : this("Unknown", 0)
        {
        }

        public override string ToString()
        {
            // Convertendo as notas para uma string adequada
            var gradesText = Grades.Count > 0 ? string.Join(", ", Grades) : "Nenhuma nota atribuída";
            return $"Name: {Name}, Age: {Age}, Student ID: {StudentId}, Grades: {gradesText}";
        }

        public void AddGrade(double grade)
        {
            if (IsValidGrade(grade))
            {
                Grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Nota inválida. A nota deve ser entre 0 e 100.");
            }
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

        protected bool IsValidGrade(double grade)
        {
            return grade >= 0 && grade <= 100;
        }

        private void PrivateMethod()
        {
            Console.WriteLine("Este é um método privado na classe Student.");
        }
    }
}
