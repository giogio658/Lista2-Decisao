Console.Write("Digite o valor do primeiro lado do triângulo: ");
double lado1 = double.Parse(Console.ReadLine());
Console.Write("Digite o valor do segundo lado do triângulo: ");
double lado2 = double.Parse(Console.ReadLine());
Console.Write("Digite o valor do terceiro lado do triângulo: ");
double lado3 = double.Parse(Console.ReadLine());
if (lado1 < lado2 + lado3 && lado2 < lado1 + lado3 && lado3 < lado1 + lado2)
{
    if (lado1 == lado2 && lado2 == lado3)
    {
        Console.WriteLine("Os lados formam um triângulo equilátero");
    }
    else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
    {
        Console.WriteLine("Os lados formam um triângulo isósceles");
    }
    else
    {
        Console.WriteLine("Os lados formam um triângulo escaleno");
    }
}
else
{
    Console.WriteLine("Os lados não formam um triângulo");
}