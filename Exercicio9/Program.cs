Console.Write("Digite o sexo da pessoa (M/F): ");
string sexo = Console.ReadLine();
Console.Write("Digite o peso da pessoa (em kg): ");
double pesoPessoa = double.Parse(Console.ReadLine());
Console.Write("Digite a altura da pessoa (em m): ");
double alturaPessoa = double.Parse(Console.ReadLine());
double imcPessoa = pesoPessoa / (alturaPessoa * alturaPessoa);
if (sexo.ToUpper() == "M")
{
    if (imcPessoa < 20)
    {
        Console.WriteLine("A pessoa está abaixo do peso");
    }
    else if (imcPessoa >= 20 && imcPessoa < 25)
    {
        Console.WriteLine("A pessoa está com o peso ideal");
    }
    else
    {
        Console.WriteLine("A pessoa está acima do peso");
    }
}
else if (sexo.ToUpper() == "F")
{
    if (imcPessoa < 19)
    {
        Console.WriteLine("A pessoa está abaixo do peso");
    }
    else if (imcPessoa >= 19 && imcPessoa < 24)
    {
        Console.WriteLine("A pessoa está com o peso ideal");
    }
    else
    {
        Console.WriteLine("A pessoa está acima do peso");
    }
}
else
{
    Console.WriteLine("Sexo inválido");
}