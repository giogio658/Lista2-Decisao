Console.Write("Digite o valor do primeiro lado do triângulo: ");
double ladoA = double.Parse(Console.ReadLine());
Console.Write("Digite o valor do segundo lado do triângulo: ");
double ladoB = double.Parse(Console.ReadLine());
Console.Write("Digite o valor do terceiro lado do triângulo: ");
double ladoC = double.Parse(Console.ReadLine());
if (ladoA < ladoB + ladoC && ladoB < ladoA + ladoC && ladoC < ladoA + ladoB)
{
    if (ladoA * ladoA == ladoB * ladoB + ladoC * ladoC || ladoB * ladoB == ladoA * ladoA + ladoC * ladoC || ladoC * ladoC == ladoA * ladoA + ladoB * ladoB)
    {
        Console.WriteLine("Os lados formam um triângulo retângulo");
    }
    else
    {
        Console.WriteLine("Os lados formam um triângulo não retângulo");
    }
}
else
{
    Console.WriteLine("Os lados não formam um triângulo");
}