using exemplos_interface;


bool loop = true;
Carrinho carrinho = new Carrinho();

Produto p1 = new Produto(1, "GTA V", 52.90f);
Produto p2 = new Produto(2, "Detroit Become Human", 120.50f);
Produto p3 = new Produto(3, "Forza", 100f);


do
{
    Console.WriteLine($"Oque vamos fazer agora?");

    Console.WriteLine(@$"
1 - Cadastrar
2 - Atualizar
3 - Listar
4 - Remover
0 - Sair 
");
    string resposta = Console.ReadLine()!;

    switch (resposta)
    {
        case "1":
            Console.Clear();
            carrinho.Adicionar(p1);
            carrinho.Adicionar(p2);
            carrinho.Adicionar(p3);
            Console.WriteLine($"Produtos cadastrados!");
            break;

        case "2":
            Console.Clear();
            // criar um objeto atualizado
            Produto _novoProduto = new Produto();
            _novoProduto.Nome = "Fifa 23";
            _novoProduto.Preco = 300f;
            carrinho.Atualizar(1, _novoProduto);
            Console.WriteLine($"Item atualizado!");
            break;

        case "3":
            Console.Clear();
            carrinho.Listar();
            carrinho.TotalCarrinho();
            break;

        case "4":
            Console.Clear();
            carrinho.Remover(p2);
            Console.WriteLine($"Item Removido");
            break;

        case "0":
            Console.Clear();
            loop = false;
            break;
        
        default:
        Console.WriteLine($"Digite uma opção válida!");
            break;
    }
} while (loop != false);



