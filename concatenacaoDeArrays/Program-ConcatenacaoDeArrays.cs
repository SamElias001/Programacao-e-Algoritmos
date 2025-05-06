
Console.WriteLine("Informe o tamanho do primeiro array:");
int t1 = Convert.ToInt32(Console.ReadLine());
int[] a1 = new int[t1];

Console.WriteLine("Informe os elementos do primeiro array:");
for (int i = 0; i < t1; i++)
{
    a1[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Informe o tamanho do segundo array:");
int t2 = Convert.ToInt32(Console.ReadLine());
int[] a2 = new int[t2];

Console.WriteLine("Informe os elementos do segundo array:");
for (int i = 0; i < t2; i++)
{
    a2[i] = Convert.ToInt32(Console.ReadLine());
}

int[] arrayConcatenado = new int[t1 + t2];
a1.CopyTo(arrayConcatenado, 0);
a2.CopyTo(arrayConcatenado, t1);

Console.WriteLine("Array concatenado:");
foreach (int elemento in arrayConcatenado)
{
    Console.Write(elemento + " ");
}