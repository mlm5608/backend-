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
    }
}