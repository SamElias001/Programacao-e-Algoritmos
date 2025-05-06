Console.WriteLine("Informe o número");
int numero = Convert.ToInt32(Console.ReadLine());

int pares = 0;
int impares = 0;
int i = 1;

while(i <= numero)
{
    if(i % 2 == 0)
    {
        pares += i;
        Console.WriteLine($"{i} é Par");
    }
    else
    {
        impares += i;
        Console.WriteLine($"{i} é Ímpar");
    }
    i++;
}

Console.WriteLine($"{pares} é a soma de todos os números Pares");
Console.WriteLine($"{impares} é a soma de todos os números Ímpares");