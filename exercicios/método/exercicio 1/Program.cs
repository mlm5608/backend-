// crisr metodo para multiplicar/dividir/subtrair 2 números

// subtração

Console.WriteLine($"digite o 1º número");
float numero1 = float.Parse(Console.ReadLine()!);

Console.WriteLine($"digite o 2º número");
float numero2 = float.Parse(Console.ReadLine()!);

Console.WriteLine(@$"escolha a operação
som - soma
subt - subtração
div - divisão
mult - multiplicação
");
string operação = Console.ReadLine()!.ToLower();

if (operação == "subt")
{
    static float Sub(float numero1, float numero2){
        return numero1 - numero2;
    }

    float resultado = Sub(numero1, numero2);
    Console.WriteLine(resultado);
}

else if (operação == "som")
{
    static float Som(float numero1, float numero2){
        return numero1 + numero2;
    }
    float resultado = Som(numero1, numero2);
    Console.WriteLine(resultado);
}

else if (operação == "div")
{
    static float Div(float numero1, float numero2){
        return numero1 / numero2;
    }
    float resultado = Div(numero1, numero2);
    Console.WriteLine(resultado);
}

else if (operação == "mult")
{
    static float Mult(float numero1, float numero2){
        return numero1 * numero2;
    }
    float resultado = Mult(numero1, numero2);
    Console.WriteLine(resultado);
}


