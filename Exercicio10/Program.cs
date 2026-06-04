Console.Write("Digite a primeira nota do aluno: ");
double nota1 = double.Parse(Console.ReadLine());
Console.Write("Digite a segunda nota do aluno: ");
double nota2 = double.Parse(Console.ReadLine());
double media = (nota1 + nota2) / 2;
if (media >= 5)
{
    Console.WriteLine("O aluno foi aprovado");
}
else
{
    Console.WriteLine("O aluno não foi aprovado");
}