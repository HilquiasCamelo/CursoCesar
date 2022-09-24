// Leia três números quaisquer, imprimindo-os em ordem crescente.

using System;
using System.Diagnostics.Metrics;

internal class Program
{

    private static void Main(string[] args)

    {
        Console.WriteLine("Digite 3 números aleatoriamente.: ");
        int[] vetor = new int[3];
      
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Digite as notas do aluno .: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(vetor);

        foreach (int valor in vetor)
        {
            Console.Write(" ");
            Console.Write(valor + " ");
        }
    }
}