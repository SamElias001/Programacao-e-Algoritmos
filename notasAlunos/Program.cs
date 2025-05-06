using System;

namespace tipoarray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos alunos deseja cadastrar?");
            int nDeAlunos = Convert.ToInt32(Console.ReadLine());

            int[] notas = new int[nDeAlunos];

            for (int i = 0; i < nDeAlunos; i++)
            {
                Console.WriteLine("Informe a nota do aluno " + (i + 1) + ":");
                notas[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Notas dos alunos:");
            for (int i = 0; i < nDeAlunos; i++)
            {
                Console.WriteLine("Aluno " + (i + 1) + ": " + notas[i]);
            }
        }
    }
}
