// 5. Faça um programa que receba a idade, o peso e o sexo de 10 pessoas. Calcule e imprima:    
// A.Total de Homens;      
// B.Total de Mulheres;      
// C.Média de idade dos Homens;      
// D.Média de idade das mulheres.

int sexoM = 0;
int sexoF = 0;

int idadeHomens = 0;
int idadeMulheres = 0;

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"pessoa {i}");

    Console.WriteLine(@$"
    sexo:
    m = masculino
    f = feminino
    ");
    char sexo = char.Parse(Console.ReadLine().ToLower());

    Console.WriteLine($"idade:");
    int idadePessoa = int.Parse(Console.ReadLine());

    Console.WriteLine($"peso:");
    float peso = float.Parse(Console.ReadLine());

    if (sexo == 'm')
    {
        sexoM++;
        idadeHomens = idadeHomens + idadePessoa;
    }

    else if( sexo == 'f')
    {
        sexoF++ ; 
        idadeMulheres = idadeMulheres + idadePessoa;
    }
    else
    {
        Console.WriteLine($"digite um sexo válido");
    }
}

int mediaM = idadeHomens / sexoM;
int mediaF = idadeMulheres / sexoF;

Console.WriteLine($"o numero de mulheres é {sexoF}");
Console.WriteLine($"o número de homens é {sexoM}");

Console.WriteLine($"a média da idade dos homens é {mediaM}");
Console.WriteLine($"a média da idade das mulheres é {mediaF}");