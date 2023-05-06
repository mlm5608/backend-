Console.WriteLine(" quem ganhou o jogo?");

Console.WriteLine("quantos gols (válidos) o time da casa fez?");
int timeCasa = int.Parse(Console.ReadLine()!);

Console.WriteLine("quantos gols (válidos) o time visitante fez?");
int timeVisitante = int.Parse(Console.ReadLine()!);

if (timeCasa>timeVisitante)
{
    Console.WriteLine("O time da casa venceu !!!!!");
}
else if (timeCasa<timeVisitante)
{
    Console.WriteLine("O time visitante venceu !!!!!");
}
else
{
    Console.WriteLine("Este jogo empatou..");
}