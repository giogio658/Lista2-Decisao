Console.Write("Digite o valor da base do retângulo: ");
double b = double.Parse(Console.ReadLine());
Console.Write("Digite o valor da altura do retângulo: ");
double h = double.Parse(Console.ReadLine());
double area = b * h;
Console.WriteLine("A área do retângulo é: " + area);
if (area > 100)
{
    Console.WriteLine("Terreno grande");
}