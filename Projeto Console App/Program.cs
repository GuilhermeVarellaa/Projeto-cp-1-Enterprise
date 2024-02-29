using Projeto_Class_Libary.Models;
using System;

namespace Projeto_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando instâncias de cada classe
            var student = new Student("John Doe", 20);
            var teacher = new Teacher("Jane Smith", 35);
            var course = new Course("Mathematics", "MATH101", 3);
            var school = new School("ABC High School", "123 Main St");

            // Explicando o que está sendo testado
            Console.WriteLine("Testando a funcionalidade de adicionar uma nota para um aluno:");

            // Adicionando uma nota para um aluno
            student.AddGrade(85);

            // Executando alguma funcionalidade (por exemplo, exibindo informações)
            Console.WriteLine("Student:");
            Console.WriteLine(student);

            Console.WriteLine("\nTeacher:");
            Console.WriteLine(teacher);

            Console.WriteLine("\nCourse:");
            Console.WriteLine(course);

            Console.WriteLine("\nSchool:");
            Console.WriteLine(school);

            // Laço para exibir os cursos oferecidos pela escola
            Console.WriteLine("\nCursos oferecidos pela escola:");
            foreach (var curso in school.CoursesOffered) // Renomeando a variável para 'curso'
            {
                Console.WriteLine($"Nome: {curso.Name}, Código: {curso.Code}, Horas de Crédito: {curso.CreditHours}");
            }

            // Controlador de fluxo com base na idade do professor
            Console.WriteLine("\nControlador de fluxo com base na idade do professor:");
            if (teacher.Age < 30)
            {
                Console.WriteLine("O professor é jovem.");
            }
            else
            {
                Console.WriteLine("O professor não é tão jovem.");
            }
        }
    }
}