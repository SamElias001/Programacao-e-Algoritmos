using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Insira o número que deseja a tabuada:");
        double numero = Convert.ToDouble(Console.ReadLine());

        for(int i = 1; i <= 10; i++ )
        {
            Console.WriteLine($"{numero} x {i} = {numero*i}");
        }
    }
}
