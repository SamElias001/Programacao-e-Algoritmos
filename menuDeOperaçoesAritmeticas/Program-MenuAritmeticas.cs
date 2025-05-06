Console.WriteLine("Digite a Opção Aritmética que deseja usar:");
Console.WriteLine("1.Soma");
Console.WriteLine("2.Subtração");
Console.WriteLine("3.Multiplicação");
Console.WriteLine("4.Divisão");
int oA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o Primeiro Número:");
double n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o Segundo Número");
double n2 = Convert.ToInt32(Console.ReadLine());

if(oA == 1)
{
    double soma = n1 + n2;
    Console.WriteLine($"{n1} + {n2} = {soma}");
}
else if(oA == 2)
{
    double subtracao = n1 - n2;
    Console.WriteLine($"{n1} - {n2} = {subtracao}");
}
else if(oA == 3)
{
    double multiplicacao = n1 * n2;
    Console.WriteLine($"{n1} * {n2} = {multiplicacao}");
}
else if(oA == 4)
{
    double divisao = n1 / n2;
    Console.WriteLine($"{n1} / {n2} = {divisao}");
}
else
{
    Console.WriteLine("Opção Invalida, por favor tente novamente");
}