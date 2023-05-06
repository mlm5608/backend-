// Sabemos que um aluno é aprovado caso apresente média maior ou igual a 7.0 e frequência maior ou igual a 75%. Na verdade, em uma situação real, se o aluno obtiver a frequência mínima exigida e uma média entre 3 e 7, ainda teria direito a uma última avaliação de recuperação. Como faríamos para resolver o problema em questão utilizando apenas estruturas de condição se-então-senão? Poderíamos começar avaliando a frequência do aluno, e se a mesma for menor que 75% o aluno já estaria reprovado, porém caso a frequência respeite o mínimo exigido, começaríamos a avaliar a média para saber se está aprovado, em recuperação ou reprovado.
Console.WriteLine("qual foi a frequencia do aluno de 0 a 100?");
int frequencia = int.Parse(Console.ReadLine());

if (frequencia >= 75)
{
    Console.WriteLine("Qual a nota do 1º trimestre?");
    float nota1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Qual a nota do 2º trimestre?");
    float nota2 = float.Parse(Console.ReadLine());

    Console.WriteLine("Qual a nota do 3º trimestre?");
    float nota3 = float.Parse(Console.ReadLine());

    float notaAnual = (nota1 + nota2 + nota3) / 3;
    Console.WriteLine($"a nota anual do aluno foi {notaAnual}");
    

    if(notaAnual >= 7.0)
    {
        Console.WriteLine("Ele está aprovado");
    }
    else if(notaAnual > 3 && notaAnual<7)
    {
        Console.WriteLine("Ele está de recuperação");
    }
    else
    {
        Console.WriteLine($"Ele está reprovado");
        
    }
} 
else
{
    Console.WriteLine("ele está reprovado");
}