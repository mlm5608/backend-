namespace exemplos_interface
{
    public class Carrinho : ICarrinho
    {
        // Propriedades
        public float Valor { get; set; }

        // Criar uma lista para manipular os nossos objetos

        List<Produto> carrinho = new List<Produto>();

        // Métodos Herdados
        public void Adicionar(Produto _produto)
        {
            carrinho.Add(_produto);
        }

        public void Atualizar(int _codigo, Produto _novoProduto)
        {
            carrinho.Find(x => x.Codigo == _codigo).Nome = _novoProduto.Nome;
            carrinho.Find(x => x.Codigo == _codigo).Preco = _novoProduto.Preco;
        }

        public void Listar()
        {
            if (carrinho.Count > 0)
            {
                foreach (Produto p in carrinho)
                {
                    Console.WriteLine(@$"
{p.Nome} / {p.Codigo}
Preço:{p.Preco:C}
                    ");
                }
            }
            else
            {
                Console.WriteLine($"Tem nada aqui não");
            }
        }

        public void Remover(Produto _produto)
        {
            carrinho.Remove(_produto);
        }

        // Métodos criados
        public void TotalCarrinho()
        {
            Valor = 0;

            if (carrinho.Count > 0)
            {
                foreach (Produto p in carrinho)
                {
                    Valor += p.Preco;
                }

                Console.WriteLine($"O total do carrinho é {Valor:C}");
            }
            else
            {
                Console.WriteLine($"Não tem nada aqui não!");
            }
        }
    }
}