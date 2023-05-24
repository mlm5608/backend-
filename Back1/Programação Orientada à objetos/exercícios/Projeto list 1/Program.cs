using Projeto_list_1;

List<Carro> carros = new List<Carro>();


for (int i = 0; i < 2; i++)
{
    //Carro carro = new Carro() 

    Console.WriteLine($"digite a marca do  {i + 1}º carro");
    string marca = Console.ReadLine()!.ToUpper();
    // carro.Marca

    Console.WriteLine($"digite a cor do {i + 1}º carro");
    string cor = Console.ReadLine()!.ToUpper();
    // carro.Cor

    carros.Add(
        new Carro(marca, cor)
    );
}

Console.WriteLine(@$"

***********************************************************
Lista
");

foreach (var item in carros)
{
    Console.WriteLine(@$"
Carro {carros.IndexOf(item) + 1}
Marca: {item.Marca}
Cor: {item.Cor}
");
}