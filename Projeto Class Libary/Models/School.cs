using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Class_Libary.Models
{
    /// <summary>
    /// Classe Estudante, contem as notas e infosmações pessoais
    /// </summary>
    public class School
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Course> CoursesOffered { get; private set; }

        internal bool ProfessorCurso(String teacherId)
        {
            return CoursesOffered.Any(course => course.Teachers.Contains(teacherId));
        }

        public School(string name, string address)
        {
            Name = name;
            Address = address;
            CoursesOffered = new List<Course>();
        }

        public void AddCourse(Course course)
        {
            if (!CourseExists(course.Code))
            {
                CoursesOffered.Add(course);
            }
            else
            {
                Console.WriteLine($"O curso com o código {course.Code} já existe.");
            }
        }

        public override string ToString()
        {
            return $"School Name: {Name}, Address: {Address}, Number of Courses Offered: {CoursesOffered.Count}";
        }

        internal bool CourseExists(string courseCode)
        {
            return CoursesOffered.Any(course => course.Code == courseCode);
        }
    }
}
