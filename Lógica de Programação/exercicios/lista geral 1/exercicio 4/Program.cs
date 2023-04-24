// 4 - Faça um programa que leia 10 valores digitados pelo usuário e no final, escreva o maior e o menor valor lido.

float[] numeros = new float[10];
int menorNúmero = 0;
int maiorNúmero = 0;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"digite o {i + 1}º numero");
    números[i] = float.Parse(Console.ReadLine()!);
}

if (i == 0)
{
    menorNúmero = numeros[0];
    maiorNúmero = numeros[0];
}