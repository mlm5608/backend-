using Console_MVC.Model;

namespace Console_MVC.View
{
    public class ProdutoView
    {
        // Método para exibir os dados da lista no console

        public void Listar(List<Produto> produto)
        {
            foreach (var item in produto)
            {
                Console.WriteLine(@$"
Código: {item.Codigo}              
Nome: {item.Nome}          
Preço: {item.Preco:C}
");
                
            }
        }
         public Produto Cadastrar()
        {
            Produto novoProduto = new Produto();
            Console.WriteLine($"Infome o código do produto");
            novoProduto.Codigo = int.Parse(Console.ReadLine()!);
            
            Console.WriteLine($"Infome o nome do produto");
            novoProduto.Nome = Console.ReadLine();
            
            Console.WriteLine($"Infome o preço do produto");
            novoProduto.Preco= float.Parse(Console.ReadLine()!);
            
            return novoProduto;
        }
    }
}