// Faça um programa que leia três números e mostre o maior e o menor deles.

Console.WriteLine("descobrir qual número é maior e qual é menor");

Console.WriteLine($"digite o 1º valor");
int valor1 = int.Parse(Console.ReadLine());

Console.WriteLine($"digite o 2º valor");
int valor2 = int.Parse(Console.ReadLine());

Console.WriteLine($"digite o 3º valor");
int valor3 = int.Parse(Console.ReadLine());

// valor: ++1 e --3
if (((valor1 > valor2) && (valor1 > valor3)) && (valor2 > valor3))
{
    Console.WriteLine($"O maior valor é o {valor1} e o menor é o {valor3}");
}
// valor: ++1 e --2
else if (((valor1 > valor2) && (valor1 > valor3)) && (valor2 < valor3))
{
    Console.WriteLine($"O maior valor é o {valor2} e o menor é o {valor3}");
}
// valor: ++2 e --1
else if (((valor2 > valor1) && (valor2 > valor3)) && (valor1 < valor3))
{
    Console.WriteLine($"O maior valor é o {valor2} e o menor é o {valor1}");
}
// valor: ++2 e --3 
else if (((valor2 > valor1) && (valor2 > valor3)) && (valor3 < valor2))
{
    Console.WriteLine($"O maior valor é o {valor3} e o menor é o {valor2}");
}
// valor: ++3 e --1
else if (((valor3 > valor1) && (valor3 > valor2)) && (valor1 < valor2))
{
    Console.WriteLine($"O maior valor é o {valor3} e o menor é o {valor1}");
}
// valor: ++3 e --2
else if (((valor3 > valor1) && (valor3 > valor2)) && (valor1 < valor2))
{
    Console.WriteLine($"O maior valor é o {valor3} e o menor é o {valor2}");
}