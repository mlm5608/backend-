//  Faça um programa que leia um nome de usuário e a sua senha e não aceite a senha igual ao nome do usuário, mostrando uma mensagem de erro e voltando a pedir as informações.

Console.WriteLine($"digite o nome de usuário:");
string nome = Console.ReadLine();

Console.WriteLine($"digite a senha:");
string senha = Console.ReadLine();

while (senha == nome)
{
    Console.WriteLine($"digite uma senha diferente do nome de usuário");
    senha = Console.ReadLine();
}

