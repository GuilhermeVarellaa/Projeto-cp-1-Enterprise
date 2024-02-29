using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Class_Libary.Models
{
    public class Grade
    {
        public string StudentId { get; set; }
        public string CourseCode { get; set; }
        public double Value { get; set; }

        public Grade(string studentId, string courseCode, double value)
        {
            StudentId = studentId;
            CourseCode = courseCode;
            Value = value;
        }

        public override string ToString()
        {
            return $"Student ID: {StudentId}, Course Code: {CourseCode}, Value: {Value}";
        }
    }
}
