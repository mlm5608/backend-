using System.Globalization;
using exercicio_aula_09_05;

float valor;
bool repeticao = true;

do
{


    Console.WriteLine(@$"
Vamos converter valores?

De qual para valor você quer converter? (Escolha uma opção?)

1 - Dólar para Euro
2 - Dólar para Real
3 - Euro para Dólar
4 - Euro para Real
5 - Real para Dólar
6 - Real para Euro

0 - sair
");
    string opções = Console.ReadLine()!;

    switch (opções)
    {
        case "1":
            Console.WriteLine($"quantos dólares serão convertidos?");
            valor = float.Parse(Console.ReadLine()!);

            Console.Clear();
            Console.WriteLine($"{ConversaoMoedas.DolarEuro(valor).ToString("C", CultureInfo.CreateSpecificCulture("es-ES"))}");
            break;

        case "2":
            Console.WriteLine($"quantos dólares serão convertidos?");
            valor = float.Parse(Console.ReadLine()!);

            Console.Clear();
            Console.WriteLine($"{ConversaoMoedas.DolarReal(valor):c}");
            break;

        case "3":
            Console.WriteLine($"quantos euros serão convertidos?");
            valor = float.Parse(Console.ReadLine()!);

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine($"{ConversaoMoedas.EuroDollar(valor).ToString("C", CultureInfo.CreateSpecificCulture("en-US"))}");
            break;

        case "4":
            Console.WriteLine($"quantos euros serão convertidos?");
            valor = float.Parse(Console.ReadLine()!);

            Console.Clear();
            Console.WriteLine($"{ConversaoMoedas.EuroReal(valor):c}");
            break;

        case "5":
            Console.WriteLine($"quantos reais serão convertidos?");
            valor = float.Parse(Console.ReadLine()!);

            Console.Clear();
            Console.WriteLine($"{ConversaoMoedas.RealDollar(valor).ToString("C", CultureInfo.CreateSpecificCulture("en-US"))}");
            break;

        case "6":
            Console.WriteLine($"quantos reais serão convertidos?");
            valor = float.Parse(Console.ReadLine()!);

            Console.Clear();
            Console.WriteLine($"{ConversaoMoedas.RealEuro(valor).ToString("C", CultureInfo.CreateSpecificCulture("es-ES"))}");
            break;

        case "0":
            Console.Clear();
            repeticao = false;
            break;

        default:
            Console.Clear();
            Console.WriteLine($"Digite uma opção valida!");
            break;
    }
} while (repeticao != false);

