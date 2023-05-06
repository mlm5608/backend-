Console.WriteLine("de que tipo é esse triângulo");

Console.WriteLine("medida lado 1:");
float lado1 = float.Parse(Console.ReadLine());

Console.WriteLine("medida lado 2:");
float lado2 = float.Parse(Console.ReadLine());

Console.WriteLine("medida lado 3:");
float lado3 = float.Parse(Console.ReadLine());

if((lado1 == lado2) && (lado2 == lado3))
{
    Console.WriteLine("este triangulo é equilátero");
}

else if((lado1 == lado2) || (lado2 == lado3) || (lado1 == lado3))
{
    Console.WriteLine("este triangulo é isoceles");
}
else
{
    Console.WriteLine("este triangulo é escaleno");
}