// Vamos desenvolver um programa que cadastre e mostre os dados de um aluno;
// Crie uma classe Aluno com as seguintes propriedades:
// Nome, Curso, Idade, RG, Bolsista (boolean), Média Final e Valor da Mensalidade. 
// Também teremos os métodos: 
// VerMediaFinal() e VerMensalidade(), caso seja bolsista faremos o cálculo da mensalidade.
// obs:
// bolsista e média final maior ou igual a 8 conceder 50% de desconto na mensalidade
// bolsista e média final maior que 6 e menor que 8 conceder 30% de desconto na mensalidade 
// outros casos a mensalidade será integral
// Receba os dados do cadastro via console e crie um menu para o usuário escolher se quer visualizar a média ou o valor da mensalidade.
// Acrescente o que achar necessário.


using preojeto_aluno;

aluno dado = new aluno();

Console.WriteLine($"digite o nome do aluno:");
dado.nome = Console.ReadLine()!.ToLower();

Console.WriteLine($"digite o curso do aluno:");
dado.curso = Console.ReadLine()!.ToLower();

Console.WriteLine($"digite a idade do aluno:");
dado.idade = int.Parse(Console.ReadLine());

Console.WriteLine($"digite o rg do aluno:");
dado.RG = int.Parse(Console.ReadLine());

dado.bolsa = false;

Console.WriteLine($"qual a média final do aluno?");
dado.mediaF = float.Parse(Console.ReadLine()!);

dado.VerMediaFinal(dado.mediaF);

Console.WriteLine($"qual a mensalidade inegral?");
dado.mensalidade = float.Parse(Console.ReadLine());

dado.VerMensalidade(dado.mensalidade, dado.valorBolsa);

Console.WriteLine(@$"
Dados Pessoais:
{dado.nome}
{dado.curso}
{dado.idade}
{dado.RG}

Bolsa:
{dado.bolsa}
{dado.valorBolsa}%

Mensalidade com desconto(ou não):
R${dado.valorMensalidade}
");
