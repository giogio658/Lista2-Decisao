Console.Write("Digite o valor da base do retângulo: ");
double b2 = double.Parse(Console.ReadLine());
Console.Write("Digite o valor da altura do retângulo: ");
double h2 = double.Parse(Console.ReadLine());
double area2 = b2 * h2;
Console.WriteLine("A área do retângulo é: " + area2);
if (area2 > 100)
{
    Console.WriteLine("Terreno grande");
}
else
{
    Console.WriteLine("Terreno Pequeno");
}