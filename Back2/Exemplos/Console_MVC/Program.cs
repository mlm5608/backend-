using Console_MVC.Model;
using Console_MVC.Controller;

Produto p = new Produto();

ProdutoController produtoController = new ProdutoController();

produtoController.cadastrarProdutos();
produtoController.listarProdutos();