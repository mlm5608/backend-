// 5 - Escreva um algoritmo que imprima a tabuada (de 1 a 10) para os números de 1 a 10.
// Exemplo: tabuada do 1, tabuada do 2, etc... Dica: utilize um laço dentro do outro.

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"tabuada do {i}");
    
    for (int x = 1; x <=10; x++)
    {
        int resultado = i * x;
        Console.WriteLine($" {i} X {x} = {resultado}");
    }
}

