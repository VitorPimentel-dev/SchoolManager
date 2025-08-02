

using SchoolManager.Entities;

namespace SchoolManager.Services
{
    internal class Menu
    {
        public void Run()
        {
            StudentsManager manager = new StudentsManager();
            int n = 1;
            while (n != 0)
            {
                Console.WriteLine("1. Adicionar estudante");
                Console.WriteLine("2. Exibir estudantes");
                Console.WriteLine("0. Sair");

                while (!int.TryParse(Console.ReadLine(), out n) || (n < 0 || n > 2))
                {
                    Console.Write("Opção inválida. Tente novamente:");
                }

                switch (n)
                {
                    case 1:
                        {
                            Console.Write("Entre com o nome do estudante: ");
                            string name = Console.ReadLine()!;

                            int id;
                            Console.Write("Entre com o ID do estudante: ");
                            while (!int.TryParse(Console.ReadLine(), out id))
                            {
                                Console.Write("ID inválido. Digite um número inteiro:");
                            }

                            int p1, p2, p3;
                            Console.WriteLine("Entre com as notas:");

                            Console.Write("P1: ");
                            while (!int.TryParse(Console.ReadLine(), out p1))
                            {
                                Console.Write("Nota inválida. Digite um número inteiro:");
                            }

                            Console.Write("P2: ");
                            while (!int.TryParse(Console.ReadLine(), out p2))
                            {
                                Console.Write("Nota inválida. Digite um número inteiro:");
                            }

                            Console.Write("P3: ");
                            while (!int.TryParse(Console.ReadLine(), out p3))
                            {
                                Console.Write("Nota inválida. Digite um número inteiro:");
                            }

                            Student student = new Student(id, name, p1, p2, p3);

                            if (!manager.TryAdd(student))
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
                            manager.PrintAll();
                            break;
                        }
                    case 0:
                        {
                            Console.WriteLine("Saindo...");
                            break;
                        }
                }
            }

        }
    }
}
