Console.Write("Digite o primeiro valor: ");
int v5 = int.Parse(Console.ReadLine());
Console.Write("Digite o segundo valor: ");
int v6 = int.Parse(Console.ReadLine());
Console.Write("Digite o terceiro valor: ");
int v7 = int.Parse(Console.ReadLine());
if (v5 > v6 && v5 > v7)
{
    Console.WriteLine("O maior valor é: " + v5);
}
else if (v6 > v5 && v6 > v7)
{
    Console.WriteLine("O maior valor é: " + v6);
}
else if (v7 > v5 && v7 > v6)
{
    Console.WriteLine("O maior valor é: " + v7);
}
else
{
    Console.WriteLine("Os valores são iguais");
}