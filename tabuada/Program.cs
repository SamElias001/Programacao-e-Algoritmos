Console.WriteLine("Informe o número que deseja a tabuada");
int n = Convert.ToInt32(Console.ReadLine());

int l = 1; 

while (l <= 10) 
{
    Console.WriteLine(n + " x " + l + " = " + (n * l)); 
    l++;
}
