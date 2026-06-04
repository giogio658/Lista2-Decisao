Console.Write("Digite a primeira nota do aluno (P1): ");
double n1 = double.Parse(Console.ReadLine());
double notaNecessaria = (15 - n1) / 2;
if (notaNecessaria <= 0)
{
    Console.WriteLine("O aluno está aprovado");
}
else if (notaNecessaria > 10)
{
    Console.WriteLine("Reprovado. O aluno precisaria de {0}, mas a nota máxima é 10.", notaNecessaria);
}
else
{
    Console.WriteLine("O aluno precisa de {0} pontos na segunda prova para ser aprovado.", notaNecessaria);
}