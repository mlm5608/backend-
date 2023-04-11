// sem array********************************

// string carro1;
// string carro2;
// string carro3;

// Console.WriteLine($"digite o nome do carro:");
// carro1 = Console.ReadLine()!;
// Console.WriteLine($"digite o nome do carro:");
// carro2 = Console.ReadLine()!;
// Console.WriteLine($"digite o nome do carro:");
// carro3 = Console.ReadLine()!;

// Console.WriteLine($"{carro1} {carro2} {carro3}");

// com array******************************

// string[] carros = new string[3];

// Console.WriteLine($"digite o nome do carro");
// carros[0] = Console.ReadLine()!;

// Console.WriteLine($"digite o nome do carro");
// carros[1] = Console.ReadLine()!;

// Console.WriteLine($"digite o nome do carro");
// carros[2] = Console.ReadLine()!;

// Console.WriteLine($"o 1º carro da lista: {carros[0]}");
// Console.WriteLine($"o 2º carro da lista: {carros[1]}");
// Console.WriteLine($"o 3º carro da lista: {carros[2]}");

string[] carros = new string[3];

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"digite o nome do {i + 1}º carro:");
    carros[i] = Console.ReadLine()!;
}
for (int i = 0; i < 3; i++)
{
        Console.WriteLine($"O {i + 1}º carro é: {carros[i]}");
}