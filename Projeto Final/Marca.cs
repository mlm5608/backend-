namespace Projeto_Final
{
    public class Marca
    {
        private int Codigo { get; set; }
        private string NomeMarca { get; set; }
        private string DataCadastro = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");

        List<Marca> Marcas = new List<Marca>();

        // Métodos
        public Marca(int _codigo)
        {
            _codigo = Codigo;
        }
        public Marca(int _codigo, string _nomeMarca)
        {
            Codigo = _codigo;
            NomeMarca = _nomeMarca;
        }

        public void Cadastrar(int _codigo, string _nomeMarca)
        {
            Marcas.Add(
                new Marca(Codigo, NomeMarca)
            );
        }
        public void Listar()
        {
            foreach (Marca item in Marcas)
            {
                Console.WriteLine(@$"
Código: {item.Codigo}
Nome: {item.NomeMarca}
                ");

            }
        }
        public void Deletar(int _codigo)
        {
            Marca MarcaARemover = Marcas.Find(x => x.Codigo == _codigo);
            int index = Marcas.IndexOf(MarcaARemover);
            Marcas.RemoveAt(index);
        }
    }
}