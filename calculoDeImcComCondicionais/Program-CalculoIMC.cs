using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o peso (em kg): ");
        double peso = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a altura (em metros): ");
        double altura = Convert.ToDouble(Console.ReadLine());

        double imc = peso / (altura * altura);

        Console.WriteLine("O IMC é: " + imc);

        if (imc < 18.5)
        {
            Console.WriteLine("Classificação: Abaixo do peso");
        }
        else if (imc >= 18.5 && imc <= 24.9)
        {
            Console.WriteLine("Classificação: Peso normal");
        }
        else if (imc >= 25.0 && imc <= 29.9)
        {
            Console.WriteLine("Classificação: Sobrepeso");
        }
        else
        {
            Console.WriteLine("Classificação: Obesidade");
        }
    }
}
