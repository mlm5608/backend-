namespace exemplos_interface
{
    public class Produto
    {
        // Propriedades
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        // Construtores
        public Produto()
        {
            
        }
        public Produto(int _codigo, string _nome, float _preco)
        {
            Codigo = _codigo;
            Nome = _nome;
            Preco = _preco;
        }
        
        

    }
}