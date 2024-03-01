using Projeto_Class_Libary.Models;
using System;

namespace Projeto_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando instâncias das classes
            var student = new Student("Felipe Varella", 21);
            var teacher = new Teacher("Douglas", 81);
            var course = new Course("Mathematics", "MATH101", 3);
            var ads = new Course("Análise e desenvolvimento de sistemas", "ADS00", 15);
            var Ingles = new Course("Ingles Empresarial", "Eng01", 5);
            var school = new School("Fiap 2k mês", "Paulista");

            //adicionando os cursos a escola
            school.AddCourse(course);
            school.AddCourse(ads);
            school.AddCourse(Ingles);


            Console.WriteLine("Testando a funcionalidade de adicionar uma nota para um aluno:");
            // Setando uma nota para um aluno
            student.AddGrade(85);
            Console.WriteLine("Estudante:");
            Console.WriteLine(student);

          
            

            Console.WriteLine("\nProfessor:");
            Console.WriteLine(teacher);

            Console.WriteLine("\nCurso:");
            Console.WriteLine(course);

            Console.WriteLine("\nEscola:");
            Console.WriteLine(school);

            // Laço que exibe os cursos oferecidos pela esocla
            Console.WriteLine("\nCursos oferecidos pela escola:");
            foreach (var curso in school.CoursesOffered) // Renomeando a variável para curso
            {
                Console.WriteLine($"Nome: {curso.Name}, Código: {curso.Code}, Horas de Crédito: {curso.CreditHours}");
            }

            // Controlador de fluxo com base na idade do professor
            Console.WriteLine("\nControlador de fluxo com base na idade do professor:");
            if (teacher.Age < 30)
            {
                Console.WriteLine("O professor ainda tem pique.");
            }
            else
            {
                Console.WriteLine("O professor já ta velinho.");
            }
        }
    }
}