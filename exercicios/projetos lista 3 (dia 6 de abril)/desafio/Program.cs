//  Pesquise como funciona o algoritmo Fibonacci.
//  Faça um programa que gere a série até que o valor seja maior que 500. 

int X = 0;
int Z = 1;


while (Z <= 500)
{
    int result = X + Z;

    Console.WriteLine(result);
    
    X = Z;
    Z = result; 
}