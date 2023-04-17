// 3 - Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:
// - Se quantidade <= 5 o desconto será de 2%
// - Se quantidade > 5 e quantidade <=10 o desconto será de 3%
// - Se quantidade > 10 o desconto será de 5%
// Dica: utilize if / else if / else


Console.WriteLine($"digite o nome do produto");
string produto = Console.ReadLine()!;

Console.WriteLine($"quanto de {produto} foi adquirido ?");
float quantidade = float.Parse(Console.ReadLine()!);

Console.WriteLine($"qual o preço unitário do {produto} ?");
float preco = float.Parse(Console.ReadLine()!);



// método
static float Total(float quantidade, float preco, float desconto)
{
    return (quantidade * preco) - ((quantidade * preco) * desconto);
}


if (quantidade <= 5)
{
    float total = Total(quantidade, preco, 0.02f);
    Console.WriteLine($"o total a pagar é {total} reais");
}
else if ((quantidade > 5) && (quantidade <= 10))
{
    float total = Total(quantidade, preco, 0.03f);
    Console.WriteLine($"o total a pagar é {total} reais");
}
else if (quantidade > 10)
{
    float total = Total(quantidade, preco, 0.05f);
    Console.WriteLine($"o total a pagar é {total} reais");
}