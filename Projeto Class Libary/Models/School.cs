using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Class_Libary.Models
{
    public class School
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Course> CoursesOffered { get; private set; }

        public School(string name, string address)
        {
            Name = name;
            Address = address;
            CoursesOffered = new List<Course>();
        }

        public void AddCourse(Course course)
        {
            CoursesOffered.Add(course);
        }

        public override string ToString()
        {
            return $"School Name: {Name}, Address: {Address}, Number of Courses Offered: {CoursesOffered.Count}";
        }
    }
}
