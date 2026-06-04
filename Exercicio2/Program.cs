Console.Write("Digite o primeiro valor: ");
int v3 = int.Parse(Console.ReadLine());
Console.Write("Digite o segundo valor: ");
int v4 = int.Parse(Console.ReadLine());
if (v3 > v4)
{
    Console.WriteLine("O maior valor é: " + v3);
}
else if (v4 > v3)
{
    Console.WriteLine("O maior valor é: " + v4);
}
else
{
    Console.WriteLine("Os valores são iguais");
}