// 4. Uma certa empresa fez uma pesquisa de mercado com 10 pessoas para saber se elas gostaram um determinado produto lançado. Para isso forneceu o sexo do entrevistado e sua resposta (sim ou não). Faça um programa que calcule e imprima:
// A.O número de pessoas que responderam SIM.
// B.O número de pessoas que responderam NÃO;
// C.O número de mulheres que responderam SIM;
// D.A porcentagem de homens que responderam NÃO entre todos os homens analisados.

int nMulheres = 0;
int nMulheresSim = 0;
int nMulheresNao = 0;


int nHomens = 0;
int nHomensSim = 0;
int nHomensNao = 0;


for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"pessoa {i}");
    
    Console.WriteLine(@$"
    qual o seu sexo de nacença?
    F = feminino
    M = Masculino
    ");
    char sexo = char.Parse(Console.ReadLine()!.ToUpper());

    Console.WriteLine(@$"
    gostou do produto?
    S = sim 
    N = não
    ");
    char resposta = char.Parse(Console.ReadLine()!.ToUpper());
    
    if ((sexo == 'F') && (resposta == 'S'))
    {
        nMulheres++;
        nMulheresSim++;
    }
    else if ((sexo == 'F') && (resposta == 'N'))
    {
        nMulheres++;
        nMulheresNao++;
    }
    else if ((sexo == 'M') && (resposta == 'S'))
    {
        nHomens++;
        nHomensSim++;
    }
    else if ((sexo == 'M') && (resposta == 'N'))
    {
        nHomens++;
        nHomensNao++;
    }
    else
    {
        Console.WriteLine($"resposta invalida");
    }
}

int respostasSim = nHomensSim + nMulheresSim;
int respostasNao = nHomensNao + nMulheresNao;

float mHomensNao = (nHomensNao * 100) / nHomens;


Console.WriteLine($"O número de respostas sim é: {respostasSim}");
Console.WriteLine($"o número de respostas não é: {respostasNao}");
Console.WriteLine($"o número de mulheres que responderam sim é: {nMulheresSim}");
Console.WriteLine($"a media de homens que responderam não é: {mHomensNao}%");