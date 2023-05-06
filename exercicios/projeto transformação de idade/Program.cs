// Programa de transformação de tempo

Console.WriteLine("Vamos descobrir sua idade em medidas diferentes?");

Console.WriteLine($"Informe a idade (em anos) da pessoa");
int idade = int.Parse (Console.ReadLine());

int meses = idade * 12;
Console.WriteLine($"sua idade em meses: {meses}");

int dias = meses * 30;
Console.WriteLine($"sua idade em dias: {dias}");

int horas = dias * 24;
Console.WriteLine($"sua idade em horas: {horas}");

int minutos = horas * 60;
Console.WriteLine($"sua idade em minutos: {minutos}");