// Faça um programa que carregue um array com 6 numeros inteiros. calcule e imprima a quantidade de números ímpares e a quantidade de números pares.

int[] num = new int[6];

for (int i = 0; i < 6; i++)
{
    Console.WriteLine($"giti o {i+1}º numero");
    num[i] = int.Parse(Console.ReadLine()!);
}