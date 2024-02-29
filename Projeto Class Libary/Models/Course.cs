using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Class_Libary.Models
{
    public class Course
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public int CreditHours { get; set; }

        public List<string> Teachers { get; private set; }

        public Course(string name, string code, int creditHours)
        {
            Name = name;
            Code = code;
            CreditHours = creditHours;
            Teachers = new List<string>();
        }

        public Course(string name, string code) : this(name, code, 0)
        {
        }

        public Course() : this("Unknown", "0000", 0)
        {
        }

        public void AssignTeacher(string teacherId)
        {
            Teachers.Add(teacherId);
        }

        public override string ToString()
        {
            return $"Course Name: {Name}, Code: {Code}, Credit Hours: {CreditHours}";
        }
    }
}
