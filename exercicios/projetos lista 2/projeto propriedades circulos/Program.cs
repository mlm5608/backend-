// Escreva um programa que pergunte o raio de uma circunferência, e sem seguida mostre o diâmetro, comprimento e área da circunferência.

Console.WriteLine("digite o valor do raio em centimetros");
int raio = int.Parse(Console.ReadLine());

int diametro = raio + raio;
double comprimento = 2 * Math.PI * raio;
double área = Math.PI * (raio * raio);

Console.WriteLine($"o diametro da circunferencia é de: {diametro} centimetros");
Console.WriteLine($"o comprimento da circunferencia é de: {comprimento} centimetros");
Console.WriteLine($"a área da circunferencia é de: {área} centimetros quadrados");
