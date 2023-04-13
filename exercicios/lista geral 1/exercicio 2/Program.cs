// 2 - Um posto está vendendo combustíveis com a seguinte tabela de descontos:
// Álcool:
// . até 20 litros, desconto de 3% por litro Álcool
// . acima de 20 litros, desconto de 5% por litro
// Gasolina:
// . até 20 litros, desconto de 4% por litro Gasolina
// . acima de 20 litros, desconto de 6% por litro

// Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
// da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
// sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.
// Dica: utilize switch case e funções/métodos para otimizar o algorítimo.



static float Total(float preçoTipo, float desconto, float litros){
    return (preçoTipo * litros) - (desconto * litros);
}

Console.WriteLine(@$"qual tipo de combustível foi vendido?
a - álcool
g - gasolina
");
char tipo = char.Parse(Console.ReadLine()!.ToLower());

Console.WriteLine($"quantos litros foram colocados?");
float litros = int.Parse(Console.ReadLine()!);

if (tipo == 'a')
{   
    if (litros <= 20)
    {
       float preço = Total(4.9f, litros, 0.03f);
       Console.WriteLine($"o preço a pagar é: {preço} reais");
    }

    else if (litros > 20)
    {
       float preço = Total(4.9f, litros, 0.05f);
       Console.WriteLine($"o preço a pagar é: {preço} reais");
    }
}

else if (tipo == 'g')
{   
    if (litros <= 20)
    {
       float preço = Total(4.9f, litros, 0.04f);
       Console.WriteLine($"o preço a pagar é: {preço} reais");
    }

    else if (litros > 20)
    {
       float preço = Total(4.9f, litros, 0.06f);
       Console.WriteLine($"o preço a pagar é: {preço} reais");
    }
}
