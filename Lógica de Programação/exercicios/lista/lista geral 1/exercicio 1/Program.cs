// 1 - Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).

int anoAtual = DateTime.Now.Year;

Console.WriteLine($"qual ano você nasceu?");
int anoPessoa = int.Parse(Console.ReadLine());

int idade = anoAtual - anoPessoa;

if (idade < 16)
{
    Console.WriteLine($"você não poderá voltar este ano!");
}
else if (((idade >= 16) && (idade < 18)) || (idade >= 70))
{
    Console.WriteLine($"se o título tiver atualizado, pode ir!");
}
else if ((idade >= 18) && (idade < 70))
{
    Console.WriteLine($"Você deve votar ou pagará uma multa!");
}