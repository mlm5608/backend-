//Faça um programa que leia e valide as seguintes informações:
// 1. Nome: diferente de vazio;
// 2. Idade: entre 0 e 100 anos;
// 3. Salário: maior que zero;
// 4. Estado Civil: 's'(solteiro(a)), 'c'(casado(a)), 'v'(viúvo(a)), 'd'(divorciado(a));

// resolução

// =================================================================
// Console.WriteLine($"digite seu nome:");
// string nome = Console.ReadLine();

// while (nome == "")
// {
//    Console.WriteLine($"Digite um nome válido!");
//    nome = Console.ReadLine();
// }

// // =================================================================
// Console.WriteLine($"digite sua idade:");
// int idade = int.Parse(Console.ReadLine());

// while ((idade < 0) || (idade > 100))
// {
//     Console.WriteLine($"digite uma idade válida!");
//     idade = int.Parse(Console.ReadLine());
// }

// // =================================================================
// Console.WriteLine($"digite seu salário:");
// float salario = float.Parse(Console.ReadLine());

// while (salario <= 0)
// {
//     Console.WriteLine($"digite um salário maior que zero!");
//     salario = float.Parse(Console.ReadLine());
// }
// // =================================================================
// Console.WriteLine(@$"
// digite uma dessas opções:
// s = solteiro(a)
// c = casado(a)
// v = viúvo(a)
// d = divorciado(a)
// ");
// char estCivil = char.Parse(Console.ReadLine().ToUpper());


// while ((estCivil != 'S') && (estCivil != 'C') && (estCivil != 'V') && (estCivil != 'D'))
// {
//     Console.WriteLine($"digite um estado civil válido");
//     Console.WriteLine(@$"
//     s = solteiro(a)
//     c = casado(a)
//     v = viúvo(a)
//     d = divorciado(a)
//     ");
//     estCivil = char.Parse(Console.ReadLine().ToUpper());
// }

for (int x = 500; x >= 0; x-=5)
{
    Console.WriteLine(x);
    
}
