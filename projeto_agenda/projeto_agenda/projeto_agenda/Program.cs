using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Agenda
  {
    public string Nome { get; set; }
    public string Endereco { get; set; }
    public string Telefone { get; set; }

    //Construtor
    public Agenda(string _nome, string _endereco, string _telfone)
    {
      this.Nome = _nome;
      this.Endereco = _endereco;
      this.Telefone = _telfone;
    }
  }

  public class Metodos
  {
    #region Métodos de inclusão, alteração e exclusão e vizualização
     
    //Método de inserção de uma nova pessoa na agenda
    public static void InserirPessoaAgenda(List<Agenda> _agendaTelefonicaList, Agenda agenda)
    {
      //recuperando agenda que foi passada como parametro
      List<Agenda> _list = _agendaTelefonicaList;

      //Adiconando nova pessoa à agenda
      _list.Add(agenda);

      //Vizualizando agenda preenchida
      Metodos.VizualizarAgenda(_list);

      //Carregando menu principal
      Metodos.CarregarMenuPrincipal();

      //Guarda o valor digitado pelo usuario
      string _menu = Console.ReadLine().ToString();

      //Realiza ação de acorodo com a opção escolhida pelo usuario
      Metodos.MenuOpcoes(_agendaTelefonicaList, _menu);
    }

    //Vizualizar agenda
    public static void VizualizarAgenda(List<Agenda> _agendaTelefonicaList)
    {
      Console.WriteLine();
      Console.WriteLine("ID\t\tNome\t\tEndereco\t\tTelefone");

      for (int i = 0; i < _agendaTelefonicaList.Count; i++)
      {

        Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}",
        i,
        _agendaTelefonicaList[i].Nome,
        _agendaTelefonicaList[i].Endereco,
        _agendaTelefonicaList[i].Telefone);
      }

      //Carregando menu principal
      Metodos.CarregarMenuPrincipal();

      //Recuperando menu digitado pela pessoa
      string _menu = Console.ReadLine().ToString();

      //Carregando menu correspodente
      Metodos.MenuOpcoes(_agendaTelefonicaList, _menu);
    }

    #endregion

    //Método que monta menu para o usuario
    public static void MenuOpcoes(List<Agenda> _agendaTelefonicaList, string _menu)
    {
        switch (_menu)
        {
            case "1":
                //Vizualizando agenda
                Metodos.VizualizarAgenda(_agendaTelefonicaList);
                break;

            case "2":
                Console.WriteLine("Digite o nome da pessoa.");
                string _nome = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Digite o endereço da pessoa.");
                string _endereco = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Digite o telefone da pessoa.");
                string _telefone = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Pessoa inserida com sucesso");
                Metodos.InserirPessoaAgenda(_agendaTelefonicaList, new Agenda(_nome, _endereco, _telefone));
                break;
            case "4":
                _agendaTelefonicaList.RemoveAt(1);
                //Console.WriteLine(_agendaTelefonicaList);
                Metodos.VizualizarAgenda(_agendaTelefonicaList);

                Console.ReadKey();
                break;
                

                //break;

            default:

                break;
        }
    }

    //Carregar MenuPrincipal
    public static void CarregarMenuPrincipal()
    {
      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine("Escolha a operação a ser realizada\n" +
                        "1 - Vizualizar agenda\n" +
                        "2 - Inserir registro na agenda\n" +
                        "3 - Alterar registro da agendar\n" +
                        "4 - Excluir registro da agendar\n" +
                        "5 - Fechar aplicão");
    }

  }

  class Program
  {
    static void Main(string[] args)
    {
      //Criamos um arrayList para guarda Nome, Endereco e Telefone
      List<Agenda> _agendaTelefonicaList = new List<Agenda>();

      //Preenchendo arrayList
      _agendaTelefonicaList.Add(new Agenda("Junior", "Rua Candido", "8989-8989"));
      _agendaTelefonicaList.Add(new Agenda("Alex", "Rua Heli Costa", "1111-5245"));
      _agendaTelefonicaList.Add(new Agenda("Rodrigo", "Rua Otavio", "6565-878"));

      //Carregando menu principal
      Metodos.CarregarMenuPrincipal();

      //Guarda o valor digitado pelo usuario
      string _menu = Console.ReadLine().ToString();

      //Realiza ação de acorodo com a opção escolhida pelo usuario
      Metodos.MenuOpcoes(_agendaTelefonicaList, _menu);

        }
     }
  }

