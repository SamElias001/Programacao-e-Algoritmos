Console.WriteLine("Informe número limte de primos verificados: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= n; i++)
{
    if(i == 2)
    {
        Console.Write(i + " ");
    }
    
    for(int i2 = 2; i2 < i; i2++)
    {
        if((i % i2 == 0))
        {
            break;
        }
        else if(i2 == i-1)
        {
            Console.Write(i + " ");
        }
        
    }
}