using System;
using System.Globalization;
using SchoolManager.Entities;

namespace SchoolManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int ,Student> students = new Dictionary<int,Student>();
            int n = 1;
            while(n != 0)
            {
                Console.WriteLine("1. Adicionar estudante");
                Console.WriteLine("2. Exibir dados dos estudantes");
                n = int.Parse(Console.ReadLine()!);
                switch(n)
                {
                    case 1:
                        {
                            Console.Write("Entre com o nome do estudante:");
                            string name = Console.ReadLine()!;
                            Console.Write("Entre com o ID do estudante: ");
                            int id = int.Parse(Console.ReadLine()!);
                            Console.WriteLine("Entre com as notas:");
                            int p1 = int.Parse(Console.ReadLine()!);
                            int p2 = int.Parse(Console.ReadLine()!);
                            int p3 = int.Parse(Console.ReadLine()!);
                            Student student = new Student(id, name, p1, p2, p3);
                            if (!students.TryAdd(student.Id, student))
                            {
                                Console.WriteLine($"Erro: Já existe um estudante com ID {student.Id}.");
                            }
                            else
                            {
                                Console.WriteLine("Estudante adicionado com sucesso!");
                            }
                            break;
                        }
                     case 2:
                        {
                            foreach(var student in students.Values)
                            {
                                Console.WriteLine(student);
                            }
                            break;
                        }
                }
            }
      
        }
    }
}
