// Faça um programa que receba um número inteiro e mostre a sua tabuada.

Console.WriteLine($"digite um número para ver sua tabuada até 10");
int numero = int.Parse(Console.ReadLine());

int multiplicador = 1;

while ( multiplicador <= 10)
{
    int resultado = numero * multiplicador;
    Console.WriteLine(@$" {multiplicador} X {numero} = {resultado}");

    multiplicador++;
}


