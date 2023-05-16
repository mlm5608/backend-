namespace Projeto_Final
{
    public class Produto
    {
        private int Codigo { get; set; }
        private string NomeProduto { get; set; }
        private float Preco { get; set; }
        private string DataCadastro = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
        private Marca Marca { get; set; }
        private Usuario CadastradoPor { get; set; }
        List<Produto> Produtos = new List<Produto>();

        // Métodos
        public Produto(int _codigo)
        {
            Codigo = _codigo;
        }

        public Produto(int _codigo, string _nomeProduto, float _preco, Marca _marca, Usuario _usuario, string _dataCadastro)
        {
            Codigo = _codigo;
            NomeProduto = _nomeProduto;
            Preco = _preco;
            Marca = _marca;
            CadastradoPor = _usuario;
            DataCadastro = _dataCadastro;
        }
        public void Cadastar(int _codigo, string _nomeProduto, float _preco, Marca _marca, Usuario _usuario, string _dataCadastro)
        {
            Produtos.Add(
                new Produto(Codigo, NomeProduto, Preco, Marca, CadastradoPor, DataCadastro)
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
Marca: {item.Marca}
Cadastro por: {item.CadastradoPor}
Data/Hora do cadastro: {item.DataCadastro}
");

            }
        }
        public void Deletar(int _codigo)
        {
            Produto ProdutoARemover = Produtos.Find(x => x.Codigo == Codigo);
            int index = Produtos.IndexOf(ProdutoARemover);
            Produtos.RemoveAt(index);
        }

    }
}