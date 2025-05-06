Console.WriteLine("Informe o número");
int n = Convert.ToInt32(Console.ReadLine());

int soma = 0; 

for (int i = 1; i <= n; i++)
        {
            soma += i;
            Console.WriteLine(soma);
        }

Console.WriteLine("Valor final: " + soma); 
