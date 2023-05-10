// criar lista de objetos
using exemplos_listas;

List<Produto> produtos = new List<Produto>();

produtos.Add(
    new Produto (2563, "camiseta QuickSilver", 109.99f)
);

produtos.Add(
    new Produto (1025, "tenis Naiki", 50f)
);

Produto calcaDiesel = new Produto(1526,"calca Diesel calvo Klein", 15f);
produtos.Add(calcaDiesel);

Console.WriteLine(@$"
Lista antiga
********************************************************************************
");

foreach (var item in produtos)
{
    Console.WriteLine(@$"
item: {produtos.IndexOf(item) + 1}
{item.Codigo} / {item.Nome} (Código / Nome)
{item.Preco:C} (Preço)
");
}

Produto produtoBuscado = produtos.Find(x => x.Codigo == 2563);
int index = produtos.IndexOf(produtoBuscado);

produtoBuscado.Preco = 199.90f;

produtos.RemoveAt(index);

produtos.Insert(index, produtoBuscado);

Console.WriteLine(@$"
Lista atualizada
********************************************************************************
");

foreach (var item in produtos)
{
    Console.WriteLine(@$"
item: {produtos.IndexOf(item) + 1}
{item.Codigo} / {item.Nome} (Código / Nome)
{item.Preco:C} (Preço)
");
}