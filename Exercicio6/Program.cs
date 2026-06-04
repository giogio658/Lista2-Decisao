Console.Write("Digite o peso da pessoa (em kg): ");
double peso = double.Parse(Console.ReadLine());
Console.Write("Digite a altura da pessoa (em m): ");
double altura = double.Parse(Console.ReadLine());
double imc = peso / (altura * altura);
if (imc < 18.5)
{
    Console.WriteLine("A pessoa está abaixo do peso");
}
else if (imc >= 18.5 && imc < 25)
{
    Console.WriteLine("A pessoa está com o peso ideal");
}
else
{
    Console.WriteLine("A pessoa está acima do peso");
}