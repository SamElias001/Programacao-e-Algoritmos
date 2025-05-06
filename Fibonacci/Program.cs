Console.WriteLine("Informe a quantidade de termos da sequência de Fibonacci:");
int n = Convert.ToInt32(Console.ReadLine());

int a = 0, b = 1, c;

Console.WriteLine("Sequência de Fibonacci:");
if (n >= 1) Console.Write(a + " ");
if (n >= 2) Console.Write(b + " ");

for (int i = 3; i <= n; i++)
{
    c = a + b;
    Console.Write(c + " ");
    a = b;
    b = c; 
}

