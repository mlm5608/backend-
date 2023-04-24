// escreva um pograma que receba e imprima com nome e idade de 5 pessoas
// nome em azul
// idade em verde

int[] idade  = new int [5];
string[] nome = new string [5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"digite o nome da pessoa {i + 1}");
    nome[i] = Console.ReadLine()!;
    
    Console.WriteLine($"digite a idade da pessoa {i + 1} ");
    idade[i] = int.Parse(Console.ReadLine()!);
}
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"pessoa {i + 1})");

    Console.WriteLine($"nome:");
    
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"{nome[i]}");
    Console.ResetColor();


    Console.WriteLine($"idade:");

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"{idade[i]}");
    Console.ResetColor();
}