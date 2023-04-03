// programa de descobrir idade

Console.WriteLine("Posso descobrir quantos anos você tem ?");

Console.WriteLine("Em qual ano você nasceu ?");
int anoPessoa = int.Parse (Console.ReadLine());

var data = DateTime.Now.Year;

int idadeAnos = data - anoPessoa;
Console.WriteLine($"Você tem {idadeAnos} de idade em anos");

int idadeSemanas = idadeAnos * 52;
Console.WriteLine($"Você tem {idadeSemanas} de idade em semanas");

