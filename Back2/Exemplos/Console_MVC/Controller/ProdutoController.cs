using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Console_MVC.Model;
using Console_MVC.View;

namespace Console_MVC.Controller
{
    public class ProdutoController
    {
        // instanci das classes produto e produtoview
        Produto produto =new Produto();
        ProdutoView produtoView = new ProdutoView();

        // Método contralador para acessar a listagem de produtos 
        public void listarProdutos()
        {
            List<Produto> produtos = produto.Ler();

            produtoView.Listar(produtos);
        }
         public void cadastrarProdutos(){
          Produto produto = produtoView.Cadastrar();
          produto.Inserir(produto);
        }
    }
}