using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static List<Cliente> clientes;
        static void Main(string[] args)
        {
        
              clientes = new List<Cliente>();

            Menu();
        }

        static void Menu()
        {
            
            Console.WriteLine("\n**********CADASTRO DE CLIENTES**********\n");

           

            Console.WriteLine("Para visualizar os clientes cadastrados pressione a tecla V");

            Console.WriteLine("Para cadastrar um novo cliente pressione a tecla C");

            Console.WriteLine("Para sair pressione a tecla S");

            OpcaoSelecionada();
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



            {

                StreamWriter Arquivo = new StreamWriter ("C:\\Arquivo.txt",true, Encoding.ASCII);
                 
                Console.WriteLine("Nome do Cliente: ");
                  string nome = Console.ReadLine();
                
                Console.WriteLine("Telefone do Cliente: ");
                  string Telefone = Console.ReadLine();
                
                Console.WriteLine("Email do Cliente: ");
                  string Email = Console.ReadLine();

                  Arquivo.Write("Nome do Cliente: " + nome);
                  Arquivo.Write("Telefone: " + Telefone);
                  Arquivo.Write("Email: " + Email);
                  Arquivo.Close();
                


                Cliente cliente = new Cliente()
                {
                    Nome = nome,
                    Telefone = Telefone,
                    Email = Email
                };

                try
                {
                    clientes.Add(cliente);
                }
                catch (Exception ex)
                {
                    TextWriter tw = new StreamWriter(@"C:\Temp\erro.log");
                    Console.SetError(tw);
                    Console.Error.WriteLine(ex);
                    Console.Error.Close();
                }

                Console.WriteLine(String.Format("Cadastrado efetuado com sucesso"));

            }
        }
        static void VisualizarClientes()
        {
            
            if (clientes.Count > 0)
            {
                Console.WriteLine("\nCliente(s) cadastrado(s)\n");

                foreach (Cliente cliente in clientes)
                {
                    Console.WriteLine(String.Format("{0};  {1};  {2};", cliente.Nome, cliente.Telefone, cliente.Email));
                }
            }
            else
            {
                Console.WriteLine("\nNenhum cliente cadastrado.");
            }

        }
    }
}

