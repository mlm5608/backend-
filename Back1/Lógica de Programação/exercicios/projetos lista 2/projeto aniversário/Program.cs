// Escreva um programa que pergunte o dia, mês e ano do aniversário de uma pessoa e diga se a data é válida ou não. Caso não seja, diga o motivo. Suponha que todos os meses tem 31 dias e que estejamos no ano de 2013.

Console.WriteLine("Em que dia você nasceu?");
int dia = int.Parse(Console.ReadLine());

if((dia >= 1) && (dia <= 31))
{
    Console.WriteLine("Em que mês você nasceu (o número)?");
    int mes = int.Parse(Console.ReadLine());

    if((mes >= 1) && (mes<= 12))
    {
        Console.WriteLine("Em que ano você nasceu?");
        int ano = int.Parse(Console.ReadLine());

        if(ano <= 2013)
        {
            Console.WriteLine($"seu aniversário este ano é {dia}/{mes}/2013");
        }
        else
        {
            Console.WriteLine($"data inválida");
        }
    }
    else
    {
        Console.WriteLine($"data inválida");
    }
}
else
{
 Console.WriteLine($"data inválida");
}