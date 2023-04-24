// Faça um programa que o usuário informe o salário recebido e o total gasto. Deverá ser exibido na tela “Gastos dentro do orçamento” caso o valor gasto não ultrapasse o valor do salário e “Orçamento estourado” se o valor gasto ultrapassar o valor do salário.


Console.WriteLine("Você estourou seu orçamento?");

Console.WriteLine("quanto foi seu salário?");
int salário = int.Parse(Console.ReadLine());

Console.WriteLine("quantos foram seus gastos?");
int gastos = int.Parse(Console.ReadLine());

if ( salário>=gastos)
{
    Console.WriteLine("Parabéns você não estourou seu orçamento");
}
else
{
    Console.WriteLine("Que pena você estourou seu orçamento");
}
