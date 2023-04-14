// 6 - Escreva um algoritmo que permita a leitura dos nomes de 10 pessoas e armazene os nomes lidos em um vetor. Após isto, o algoritmo deve permitir a leitura de mais 1 nome qualquer de pessoa (para efetuar uma busca) e depois escrever a mensagem ACHEI, se o nome estiver entre os 10 nomes lidos anteriormente (guardados no vetor), ou NÃO ACHEI caso contrário.
string[] nomes = new string[10];

for (int i = 1; i < 11; i++)
{
    Console.WriteLine($"digite o {i}º nome:");
    nomes[i] = Console.ReadLine()!.ToUpper();
}
 
 Console.WriteLine($"agora escolha o nome que você que saber se está aqui?");
 string nomeAvaliavel = Console.ReadLine()!;

 bool resposta = nomes.Contains(nomeAvaliavel);

 if (resposta == true)
 {
    Console.WriteLine($"Achei! o nome {nomeAvaliavel} está aqui!");
 }
 else
 {
    Console.WriteLine($"Não achei :(  este nome não está aqui!");
 }