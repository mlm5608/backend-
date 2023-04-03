// Faça um programa que verifique se uma letra digitada é vogal ou consoante

Console.WriteLine("Digite uma letra:");
string letra = Console.ReadLine()!.ToLower();
 
if ((letra == "a") || (letra == "e") || (letra == "i") || (letra == "o") || (letra == "u"))
{
    Console.WriteLine("esta letra é vogal");
}
else
{
    Console.WriteLine("esta letra é consoante");
}