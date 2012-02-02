using System;
using System.Collections.Generic;
using System.IO;

namespace MinhaConsole
{
    class Program
    {
        static List<Cliente> clientes;

        static void Main(string[] args)
        {
            ConfigurarJanela();

            clientes = new List<Cliente>();

            Menu();
        }

        static void Menu()
        {
            ConfigurarCorDaFonte(ConsoleColor.Green);

            Console.WriteLine("\n**********CADASTRO DE CLIENTES**********\n");

            ConfigurarCorDaFonte(ConsoleColor.Gray);

            Console.WriteLine("Para visualizar os clientes cadastrados pressione a tecla V");

            Console.WriteLine("Para cadastrar um novo cliente pressione a tecla C");

            Console.WriteLine("Para sair pressione a tecla S");

            OpcaoSelecionada();
        }

        static void ConfigurarCorDaFonte(ConsoleColor corDaFonte)
        {
            Console.ForegroundColor = corDaFonte;
        }

        static void ConfigurarJanela()
        {
            Console.Title = "Cadastro de Clientes";
            Console.BufferHeight = 40;
            Console.BufferWidth = 100;
            Console.SetWindowSize(100, 40);
        }

        static void OpcaoSelecionada()
        {
            ConsoleKeyInfo cki = new ConsoleKeyInfo();
            cki = Console.ReadKey(true);

            if (cki.Key == ConsoleKey.V)
            {
                VisualizarClientes();
            }
            else if (cki.Key == ConsoleKey.C)
            {
                CadastrarCliente();
            }
            else if (cki.Key == ConsoleKey.S)
            {
                Console.Beep();
                return;
            }

            Menu();
        }

        static void CadastrarCliente()
        {
            ConfigurarCorDaFonte(ConsoleColor.Blue);

            Console.WriteLine("\nNome do Cliente:");
            string nome = Console.ReadLine();

            Console.WriteLine("E-mail do Cliente:");
            string email = Console.ReadLine();

            Console.WriteLine("E-mail do Cliente:");
            string telefone = Console.ReadLine();

            Cliente cliente = new Cliente()
            {
                Nome = nome,
                Email = email,
                Telefone = telefone,
            };


            {
                clientes.Add(cliente);

                string arquivo = @"C:\agenda.txt";

                if (File.Exists(arquivo))
                {
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\agenda.txt", true))
                    {
                        file.WriteLine("Nome:" + nome);
                        file.WriteLine("Telefone:" + telefone);
                        file.WriteLine("Email:" + email);
                        file.Close();
                    }
                }
                else
                {
                    StreamWriter escrever = new StreamWriter(arquivo);
                    escrever.WriteLine("Nome:" + nome);
                    escrever.WriteLine("Telefone:" + telefone);
                    escrever.WriteLine("Email:" + email);
                    escrever.Close();
                }
            }



            Console.WriteLine(String.Format("\nO cliente {0}\n" + "Telefone: {1}\n" + "Email: {2}\n" + "\nfoi cadastrado com sucesso", nome, email, telefone));
        }
        

        static void VisualizarClientes()
        {


            string arquivo = @"C:\agenda.txt";

            if (File.Exists(arquivo))
            {
                string[] lines = System.IO.File.ReadAllLines(@"C:\agenda.txt");

                System.Console.WriteLine("Usuarios Cadastrados =:");
                foreach (string line in lines)
                {
                    Console.WriteLine("\t" + line);
                }

            }
            else
            {
                Console.WriteLine("\nNenhum cliente cadastrado.");
            }
        }
    }
}
