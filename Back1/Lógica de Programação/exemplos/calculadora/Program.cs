// calculadora

// algoritimo

// informar operação
// informar primeiro/segundo número
// processar dados
// exibir resultado

// entrada

Console.WriteLine(@$"
------------------------
|  informe a operação  |
|   (+) soma           |
|   (-) subtração      |
|   (*) multiplicação  |
|   (/)divisão         |
------------------------
");
char operacao = char.Parse(Console.ReadLine());

Console.WriteLine($"informe o primeiro número");
double num1 = double.Parse(Console.ReadLine());

Console.WriteLine($"informe o segundo número");
double num2 = double.Parse(Console.ReadLine());

double resultado = 0;

// processamento
// saida

switch (operacao)
{
    case '+':
        resultado = (num1 + num2);
        Console.WriteLine($"o resultado da soma é {resultado}");
        
        break;

    case '-':
        resultado = (num1 - num2);
        Console.WriteLine($"o resultado da subtração é {resultado}");
        
        break;

    case '*':
        resultado = (num1 * num2);
        Console.WriteLine($"o resultado da multiplicação é {resultado}");
        
        break;

    case '/':
        resultado = (num1 / num2);
        Console.WriteLine($"o resultado da divisão é {resultado}");
        
        break;

    default:
     Console.WriteLine($"operação invávilda, repita o precesso");
    
        break;
}
