// Vamos desenvolver um programa orientado a objeto que faça as 4 operações matemáticas.
// Crie uma classe Calculadora;
// Criar um método para cada uma das operações matemáticas(retornar float);
// Fazer o menu de opções;
// Solicitar a entrada de 2 números para o cálculo e exiba o resultado do cálculo no console.

using projeto_calculadora;

bool encerrar = true;

calculadora instanc = new calculadora();
do
{
    Console.WriteLine(@$"
Qual operação irá ser feita?

som -- Soma
sub -- Subtração
div -- Divisão
mult -- Multiplicação
0 -- encerar
    ");
    string operação = Console.ReadLine()!.ToUpper();

    if (operação == "SOM")
    {
        Console.WriteLine($"digite o primeiro número:");
        instanc.numero1 = float.Parse(Console.ReadLine()!);

        Console.WriteLine($"digite o segundo número");
        instanc.numero2 = float.Parse(Console.ReadLine()!);

        instanc.soma(instanc.numero1, instanc.numero2);
        Console.WriteLine($"{instanc.resultado}");
    }
    else if (operação == "SUB")
    {
        Console.WriteLine($"digite o primeiro número:");
        instanc.numero1 = float.Parse(Console.ReadLine()!);

        Console.WriteLine($"digite o segundo número");
        instanc.numero2 = float.Parse(Console.ReadLine()!);

        instanc.sub(instanc.numero1, instanc.numero2);
        Console.WriteLine($"{instanc.resultado}");
    }
    else if (operação == "DIV")
    {
        Console.WriteLine($"digite o primeiro número:");
        instanc.numero1 = float.Parse(Console.ReadLine()!);

        Console.WriteLine($"digite o segundo número");
        instanc.numero2 = float.Parse(Console.ReadLine()!);

        instanc.sub(instanc.numero1, instanc.numero2);
        Console.WriteLine($"{instanc.resultado}");
    }
    else if (operação == "MULT")
    {
        Console.WriteLine($"digite o primeiro número:");
        instanc.numero1 = float.Parse(Console.ReadLine()!);

        Console.WriteLine($"digite o segundo número");
        instanc.numero2 = float.Parse(Console.ReadLine()!);

        instanc.mult(instanc.numero1, instanc.numero2);
        Console.WriteLine($"{instanc.resultado}");
    }
    else if (operação == "0")
    {
        encerrar = false;
    }
    else
    {
        Console.WriteLine($"operação inválida!");
    }
} while (encerrar != false);