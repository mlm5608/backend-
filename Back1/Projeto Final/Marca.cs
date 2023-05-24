namespace Projeto_Final
{
    public class Marca
    {
        private int Codigo { get; set; }
        private string NomeMarca { get; set; }
        private string DataCadastro = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
        public int codigo;

        List<Marca> Marcas = new List<Marca>();

        // Métodos
        public Marca()
        {
        }
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
            Console.WriteLine($"Qual o nome da marca?");
            NomeMarca = Console.ReadLine()!.ToUpper();
            
            Console.WriteLine($"Qual o codigo da marca?");
            Codigo = int.Parse(Console.ReadLine());
            

            Marcas.Add(
                new Marca(Codigo, NomeMarca)
            );
            codigo = Codigo;
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