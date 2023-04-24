// 6. Escreva um algoritmo que imprima a tabuada (de 1 a 10) para os números de 1 a 10.

for (int multiplicando = 1; multiplicando <= 10; multiplicando++){
    Console.WriteLine($"tabuada do {multiplicando}");

    for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
    {
        int resultado = multiplicando * multiplicador; 
        Console.WriteLine($"{multiplicando} X {multiplicador} = {resultado}");
    }
}