// Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.
// Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
// O sistema deve exibir um menu com as seguintes opções:

// 1- Cadastrar passagem
// 2- Listar Passagens
// 0- Sair

// Observação :  Criar ao menos uma função (Efetuar Login).
// Ao cadastrar uma passagem ao final o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrário voltar ao menu anterior(S/N).

string[] nomePassageiro = new string[] {};
string[] origemVoo = new string[] {};
string[] destinoVoo = new string[] {};
string[] dataVoo = new string[] {};

bool respostaCadastroPassagem = false;
bool repeticaoMenu = false;
bool repeticaoTotal = false;

int i = 1;

do
{
    Console.WriteLine($"digite o nome de login:");
    string nomeLogin = Console.ReadLine()!.ToUpper();

    Console.WriteLine($"digite a senha:");
    int senhaLogin = int.Parse(Console.ReadLine()!);



    if ((nomeLogin == "MIGUEL") && (senhaLogin == 280407))
    {
        do
        {
            Console.WriteLine(@$"
    Escolha uma opção:
==========================
|  1- Cadastrar passagem |
|  2- Listar Passagens   |
|  0- Sair               |
==========================
    ");

            int opcaoMenu = int.Parse(Console.ReadLine()!);

            if (opcaoMenu == 1)
            {
                do
                {
                    Console.WriteLine($"digite o nome do passageiro");
                    nomePassageiro[i] = Console.ReadLine()!;

                    Console.WriteLine($"digite a origem do voo (ex: Brasil)");
                    origemVoo[i] = Console.ReadLine()!;

                    Console.WriteLine($"digite o destino do voo (ex: Alemanha)");
                    destinoVoo[i] = Console.ReadLine()!;

                    Console.WriteLine($"digite a data do voo (dd/mm/aaaa)");
                    dataVoo[i] = Console.ReadLine()!;

                    Console.WriteLine($"você quer cadastrar outra passagem? (s/n)");
                    char novoCadrasto = char.Parse(Console.ReadLine()!.ToLower());

                    if (novoCadrasto == 's')
                    {
                        i++;
                        respostaCadastroPassagem = true;
                    }
                    else if (novoCadrasto == 'n')
                    {
                        respostaCadastroPassagem = false;
                    }
                    else
                    {
                        Console.WriteLine($"digite uma resposta válida ");
                        novoCadrasto = char.Parse(Console.ReadLine()!.ToLower());
                    }
                } while (respostaCadastroPassagem == true);
            }

            else if (opcaoMenu == 2)
            {
                for (int x = 0; x <= nomePassageiro.Length; i++)
                {
                    Console.WriteLine(@$"
=========================================
-    passagem {x + 1}
-    {nomePassageiro[x]}                                  
-    {origemVoo[x]}  -- {destinoVoo[x]}                                  
-                                       
-    {dataVoo[x]}                                   
=========================================
                ");
                }
            }
            else if (opcaoMenu == 0)
            {
                repeticaoMenu = false;
            }
        } while (repeticaoMenu == true);
    }

    else
    {
        Console.WriteLine($"Login inválido");
    }
} while (repeticaoTotal == false);