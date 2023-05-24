// Faça um programa que faça 5 perguntas para uma pessoa sobre um crime. As perguntas são:
// "Telefonou para a vítima?"
// "Esteve no local do crime?"
// "Mora perto da vítima?"
// "Devia para a vítima?"
// "Já trabalhou com a vítima?"

int contador = 0;

Console.WriteLine($"Telefonou para a vítima?");
string telefone = Console.ReadLine()!.ToLower();
if (telefone == "sim")
{
    contador++;
}
Console.WriteLine($"Esteve no local do crime?");
string local = Console.ReadLine()!.ToLower();
if (local == "sim")
{
    contador++;
}
Console.WriteLine($"Mora perto da vítima?");
string moradia = Console.ReadLine()!.ToLower();
if (moradia == "sim")
{
    contador++;
}
Console.WriteLine($"Devia para a vítima?");
string dividendo = Console.ReadLine()!.ToLower();
if (dividendo == "sim")
{
    contador++;
}
Console.WriteLine($"Já trabalhou com a vítima?");
string colega = Console.ReadLine()!.ToLower();
if (colega == "sim")
{
    contador++;
}

// resultados

if (contador == 0)
{
   Console.WriteLine($"Ele é inocente"); 
}
else if ((contador > 0) && (contador <= 2) )
{
   Console.WriteLine($"Ele é suspeito"); 
}
else if ((contador > 2) && (contador <= 4))
{
   Console.WriteLine($"Ele é cumplice"); 
}
else 
{
   Console.WriteLine($"Ele é culpado"); 
}