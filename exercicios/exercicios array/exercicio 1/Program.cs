// criar um programa que rebeca 5 númeos inteiros e ao final exiba o seu dobro

int[] numeros = new int [5];

for (int i = 0; i < 5; i++)
{
        Console.WriteLine($"digite o {i + 1}º numero inteiro:");
    numeros[i] = int.Parse(Console.ReadLine()!);
}
foreach (var i in numeros)
{
    Console.WriteLine($" o dobro de {i} é: {i * 2}");
}