using Projeto_Final;

namespace Projeto_Final
{
    public class Produto
    {
        string User = Usuario.Name;
        string marca_;
        private int Codigo { get; set; }
        private string NomeProduto { get; set; }
        private float Preco { get; set; }
        private string DataCadastro;
        private Marca marca { get; set; }
        private Usuario CadastradoPor { get; set; }
        public string cadastradoPor = "miguel";
        public int Codigo_;
        List<Produto> Produtos = new List<Produto>();


        // Métodos
        public Produto()
        {
        }
        public Produto(int _codigo)
        {
            Codigo = _codigo;
        }

        public Produto(int _codigo, string _nomeProduto, float _preco, string _marca_, string _usuario, string _dataCadastro)
        {
            Codigo = _codigo;
            NomeProduto = _nomeProduto;
            Preco = _preco;
            _marca_ = marca_;
            User = _usuario;
            DataCadastro = _dataCadastro;
        }

        public void Cadastar(int _codigo, string _nomeProduto, float _preco, string _marca_, string _Nome, string _dataCadastro)
        {
            
            Console.WriteLine($"Qual é o codigo?");
            Codigo_ = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"Qual é o nome do produto?");
            string NomeProduto = Console.ReadLine()!.ToLower();

            Console.WriteLine($"Qual é o Preço?");
            float Preco = float.Parse(Console.ReadLine()!.ToLower());

            Console.WriteLine($"Qual é a Marca?");
            string marca_ = Console.ReadLine()!.ToUpper();

            Produtos.Add(
                new Produto(Codigo_, NomeProduto, Preco, marca_, _Nome, _dataCadastro)
            );
        }
        public void Listar()
        {
            foreach (Produto item in Produtos)
            {
                Console.WriteLine(@$"
Código: {item.Codigo}
Nome: {item.NomeProduto}
Preço: {item.Preco}
Marca: {marca_}
Cadastro por: {cadastradoPor}
Data/Hora do cadastro: {item.DataCadastro}
");

            }
        }
        public void Deletar(int _codigo)
        {
            Produto ProdutoARemover = Produtos.Find(x => x.Codigo == _codigo);
            int index = Produtos.IndexOf(ProdutoARemover);
            Produtos.RemoveAt(index);
        }

    }
}