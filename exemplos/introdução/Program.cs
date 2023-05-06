// variaveis**

// declarando variavel
// tipo nome = valor
// string nome = "leugim";
// nome = " cleiton ";
// const int idade = 69;
// Console.WriteLine($"a idade do" + nome + "é " + idade + " anos " + "de cueca no quarto");

// tipos de dados**
// int quantidade = 10;
// double preco = 4.99D;
// float altura = 1.80f;
// bool careca = true;
// string texto = "olá, mundo!";
// char letra = 'C';
// Console.WriteLine("nao sei");

// operadores aritiméticos**

// soma
// Console.WriteLine(4 + 4);
// Console.WriteLine(4 + "4");

// subtração
// Console.WriteLine(4 - 2);

// divisão
// Console.WriteLine(4 / 2);

// multiplicação
// Console.WriteLine(4 * 2);

// modular
// Console.WriteLine(5 % 2);

// operadores de compraração**

// igual a 
// Console.WriteLine(5 == 6);

// maior ou igual a 
// Console.WriteLine(5 >= 4);

// menor ou igual a 
// Console.WriteLine(4 <= 4);

//maior que 
// Console.WriteLine(5 > 1);

//menor que 
// Console.WriteLine(5 < 8);

// diferente de 
// Console.WriteLine(5 != 8);

// operadores logicos**

// && : e
// || : ou
//  ! : negação

// Console.WriteLine(5 == 5 && 8 == 8); //true && true = true
// Console.WriteLine(5 == 5 && 8 == 9); //true && false = false
// Console.WriteLine(5 == 6 && 8 == 8); //false && true = false


// Console.WriteLine(5 == 5 || 8 == 8); //true || true = true
// Console.WriteLine(5 == 5 || 8 == 9); //true || false = true
// Console.WriteLine(5 == 6 || 8 == 8); //false || true = true
// Console.WriteLine(5 == 6 || 8 == 8); //false || true = false


// Console.WriteLine(!(5 == 5 || 8 == 9)); //true || false = fals
// Console.WriteLine(!(5 == 6 || 8 == 8)); //false || true = false
// Console.WriteLine(!(5 == 6 || 8 == 8)); //false || true = true

//  programa criado para calcular imc

// string nomes = "Miguel";
// float peso = 90.8f;
// float alturas = 1.90f;

// porcessamento
// float imc = peso / (alturas * alturas);

// Console.WriteLine($"o IMC do " + nomes + " é de : " + Math.Round(imc,2)); 

// *************************************************************************** 

//Condicional Simples

// bool sol = false;

// if (sol)
// {
//     Console.WriteLine($"Vou para a praia !");        
// }

// Condicional Composta
// Console.WriteLine($"O dia está ensolarado ? Escreva SIM para caso esteja sol");
// string sol = Console.ReadLine().ToUpper();

// Console.WriteLine($"O Edu está de folga ?");
// string folga = Console.ReadLine().ToUpper();

// if ((sol == "SIM") && (folga == "SIM"))
// {
//     Console.WriteLine($"Vou para a praia!");    
// }
// else
// {
//     Console.WriteLine($"Eu vou é trabalhar!");    
// }


// string nome1 = "catarina";
// string nome2 = "Catarina";

// if (nome1 == nome2)
// {
//     Console.WriteLine($"Nomes iguais");    
// }
// else
// {
//     Console.WriteLine($"Nomes Diferentes");    
// }

// //operador ternário
// string nomeIgual = (nome1 == nome2) ? "Nomes iguais" : "Nomes Diferentes";
// Console.WriteLine(nomeIgual);

//Condicional Encadeada(aninhada ou encaixada)

// int idade = 18;

// if (idade >= 18)
// {
//     Console.WriteLine($"Pode entrar na festa, beba com moderação!");    
// }
// else if (idade >= 16 && idade <18)
// {
//     Console.WriteLine($"Pode entrar na festa com a Mamãe !");    
// }
// else
// {
//     Console.WriteLine($"Vai brincar de carrinho ou boneca!");    
// }                       
            