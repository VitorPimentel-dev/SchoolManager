using System;
using System.Globalization;
using SchoolManager.Entities;

namespace SchoolManager
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            Console.Write("Entre com o numero de estudantes:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            { 
            Console.Write("Entre com o nome do estudante:");
            string name = Console.ReadLine()!;
            Console.Write("Entre com o ID do estudante: ");
            int id = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Entre com as notas:");
            int p1 = int.Parse(Console.ReadLine()!);
            int p2 = int.Parse(Console.ReadLine()!);
            int p3 = int.Parse(Console.ReadLine()!);
            students.Add(new Student(id,name, p1, p2, p3));
                Console.WriteLine($"{students[i]}");
            }
        }
    }
}