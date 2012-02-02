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
            ConfigurarCorDaFonte(ConsoleColor.Red);

            Console.WriteLine("\n          Cadastro de Clientes DotRevolutions        \n");

            ConfigurarCorDaFonte(ConsoleColor.White);

            Console.WriteLine("Visualizar clientes cadastrados pressione: V");

            Console.WriteLine("\nCadastrar um novo cliente pressione a tecla: C");

            Console.WriteLine("\nPara sair pressione a tecla: S");

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
            else
                Console.WriteLine("Por favor digite apenas \nV - Para visualizar  \nC - para cadastrar \nS - para sair");

            Menu();
        }

        static void CadastrarCliente()
        {
            ConfigurarCorDaFonte(ConsoleColor.White);

            Console.WriteLine("\nNome do Cliente:");
            string nome = Console.ReadLine();

            Console.WriteLine("Telefone do Cliente:");
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
                string arquivo = @"c:\agenda.txt";

                if (File.Exists(arquivo))
                {
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"c:\agenda.txt", true))
                    {
                        file.WriteLine("\nNome:  " + nome + "  Telefone:  " + telefone + "  Email:  " + email);
                        file.Close();
                    }
                }
                else
                {
                    StreamWriter escrever = new StreamWriter(arquivo);
                    escrever.WriteLine("\nNome:  " + nome + "  Telefone:  " + telefone + "  Email:  " + email);
                    escrever.Close();
                }
            }



            Console.WriteLine(String.Format("\nO Cliente {0}\n" + "Telefone: {1}\n" + "Email: {2}\n" + "\nfoi cadastrado com sucesso", nome, email, telefone));
        }


        static void VisualizarClientes()
        {

            string arquivo = @"c:\agenda.txt";

            if (File.Exists(arquivo))
            {
                int counter = 0;
                string line;
                string[] array = { "nome", "telefone", "e-mail" };
                List<string> copy = new List<string>(array);
                copy.Sort();
                Console.WriteLine(string.Join(",", array));
                Console.WriteLine(string.Join(",", copy));

                Console.WriteLine("\nUsuários Cadastrados:");
                System.IO.StreamReader file =
                    new System.IO.StreamReader(@"c:\agenda.txt");
                while ((line = file.ReadLine()) != null)
                {
                    System.Console.WriteLine(line);
                    counter++;
                }

                file.Close();
                System.Console.ReadLine();
            }
            else
            {
                ConfigurarCorDaFonte(ConsoleColor.Red);
                Console.WriteLine("\nNenhum cliente cadastrado.");
            }
        }
    }
}

