namespace Projeto_Class_Libary.Models
{
    public class Teacher
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string TeacherId { get; set; }

        public List<string> Courses { get; private set; }

        public Teacher(string name, int age, string teacherId)
        {
            Name = name;
            Age = age;
            TeacherId = teacherId;
            Courses = new List<string>();
        }

        public Teacher(string name, int age) : this(name, age, GenerateTeacherId())
        {
        }

        public Teacher() : this("Unknown", 0)
        {
        }

        public void AddCourse(string course)
        {
            Courses.Add(course);
        }

        public int YearsOfService(int currentYear)
        {
            return currentYear - (Age + 18);
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Teacher ID: {TeacherId}";
        }

        private static int teacherIdCounter = 1;

        private static string GenerateTeacherId()
        {
            string teacherId = "T" + teacherIdCounter;
            teacherIdCounter++;
            return teacherId;
        }

        private void PrivateMethod()
        {
            Console.WriteLine("Este e um método privado na classe Teacher.");
        }
    }
}