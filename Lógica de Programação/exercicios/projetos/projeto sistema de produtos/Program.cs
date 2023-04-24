// Nesta aula vamos aplicar o seguinte projeto para gerenciamento de 10 produtos pelo console:
// Os produtos terão os seguintes atributos:
// string Nome
// float Preco
// bool Promocao (se está em promoção ou não)

// O sistema deverá ter as seguintes funcionalidades:
// CadastrarProduto
// ListarProdutos
// MostrarMenu
// Crie função(ões) para otimizar o código.
// Incremente o que achar necessário. Utilize sua lógica e sua criatividade.


// variaveis
string[] Produtos = new string[10];
float[] Preco = new float [10];
string[] Promocao = new string [10];

string resposta;
int i = 0;
bool repetiçãoCadastro = true;
bool repetirPergunta1 = false;


// Código
do
{
    Console.WriteLine(@$"
    1 - cadastrar produto
    2 - Listar produtos
    3 - encerar
    ");
    resposta = Console.ReadLine()!;
    if (resposta == "1")
    {
        do
        {
            Console.WriteLine($"produto {i+1}");
            
            Console.WriteLine($"Qual é o produto?");
            Produtos[i] = Console.ReadLine().ToUpper();
        
            Console.WriteLine($"Qual o preço do Produto?");
            Preco[i] = float.Parse(Console.ReadLine());

            Console.WriteLine($"O produto está em promoção?");
            Promocao[i] = Console.ReadLine();
            do
            {
                Console.WriteLine($"quer cadastrar outro produto? (sim ou não)");
                string resposta1 = Console.ReadLine().ToLower();
                
                if (resposta1 == "sim")
                {
                    repetirPergunta1 = true;
                    repetiçãoCadastro = true;
                    i++;
                    Console.Clear();
                }
                else if (resposta1 == "não")
                {
                    repetiçãoCadastro = false;
                    repetirPergunta1 = true;
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine($"resposta invalida");
                    repetirPergunta1 = false;
                }
            } while (repetirPergunta1 == false);
        } while (repetiçãoCadastro != false);
    }
    else if (resposta == "2")
    {
        Console.WriteLine(@$"
=================|
Nome   /         |
valor  /         |
está em promoção?|
=================|
");
        
        for (int x = 0; x < 10; x++)
        {
            Console.WriteLine(@$"

======================================
{Produtos[x]} 
R${Preco[x]} 
{Promocao[x]}
======================================

            ");
            
        }
    }
    else
    {
        Console.Clear();
        Console.WriteLine($"Resposta inválida");
    }

} while (resposta != "3");
Console.Clear();
