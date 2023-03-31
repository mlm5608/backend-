// As    maçãs custam R$ 0,30 cada se forem compradas    menos do que uma dúzia, e R$ 0,25 se forem compradas pelo menos doze. Escreva um programa que leia o número de maçãs compradas, calcule e escreva o valor    total    da compra.

Console.WriteLine("quantas maçãs estão sendo compradas?");
int nMaçãs = int.Parse(Console.ReadLine());

if(nMaçãs < 12)
{
    double valor1 = nMaçãs * 0.30d;
    Console.WriteLine($"o valor a ser pago é de {valor1} reais");
}
else if(nMaçãs >= 12)
{
    double valor2 = nMaçãs * 0.25d;
    Console.WriteLine($"o valor a ser pago é de {valor2} reais");
}
