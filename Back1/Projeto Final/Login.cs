using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto_Final;

namespace Projeto_Final
{
    public class Login
    {
        Produto produto_ = new Produto();
        Marca M = new Marca();
        private bool Logado { get; set; }

        // Métodos
        public void Logar()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"Qual é o email?");
            string EUser = Console.ReadLine()!;

            Console.WriteLine($"Qual é a senha?");
            string PassUser = Console.ReadLine()!;

            if ((EUser == "miguelmoreira5608@gmail.com") && (PassUser == "miguel"))
            {
                Logado = true;
            }
            else
            {
                Logado = false;
                Console.WriteLine($"Email ou senha incorretos");
            }
            Console.ResetColor();
        }
        public void Deslogar()
        {
            Logado = false;
        }
        public void GerarMenu()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@$"
Escolha 1 opção

Produtos:
1- Cadastrar Produto
2- Listar Produtos
3- Deletar Produto

Marcas:
4- Cadastrar marcas
5- Listar marcas
6- Deletar Marca

0-Sair
            ");
            Console.ReadLine();
        }

        public Login()
        {
            do
            {
                Logar();
            } while (Logado != true);
            string Resposta;
            bool loop = true;
            do
            {
                GerarMenu();
                Resposta = Console.ReadLine();



                switch (Resposta)
                {
                    case "1":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Clear();
                        int sla1 = 1;
                        string sla2 = "";
                        float sla3 = 1;
                        string sla4 = "";
                        string sla5 = "Miguel";
                        string sla6 = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                        produto_.Cadastar(sla1, sla2, sla3, sla4, sla5, sla6);
                        Console.ResetColor();
                        break;
                    case "2":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Clear();
                        produto_.Listar();
                        Console.ResetColor();
                        break;
                    case "3":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Clear();
                        Console.WriteLine($"Qual o código?");
                        int codigo_ = int.Parse(Console.ReadLine());
                        produto_.Deletar(codigo_);
                        Console.ResetColor();
                        break;
                    case "4":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Clear();
                        Console.WriteLine($"Qual o nome da marca?");
                        string NomeMarca = Console.ReadLine()!.ToUpper();

                        Console.WriteLine($"Qual o codigo da marca?");
                        int Codigo = int.Parse(Console.ReadLine());
                        M.Cadastrar(Codigo, NomeMarca);
                        Console.ResetColor();
                        break;
                    case "5":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Clear();
                        M.Listar();
                        Console.ResetColor();
                        break;
                    case "6":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Clear();
                        Console.WriteLine($"Qual o codigo da marca?");
                        int vodigo = int.Parse(Console.ReadLine());
                        M.Deletar(vodigo);
                        Console.ResetColor();
                        break;
                    case "0":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        loop = false;
                        Console.WriteLine($"Obrigado por usar nosso programa!!");
                        Console.ResetColor();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine($"Resposta inválida!");
                        break;
                }
            } while (loop != false);
        }
    }
}