// Ler cinco valores numéricos inteiros, identificar e apresentar o maior e o menor
// valores informados;

using System;
using System.Diagnostics.Metrics;

internal class Program
{

    private static void Main(string[] args)

    {
        Console.WriteLine("Digite 5 números aleatoriamente.: ");
        int[] vetor = new int[5];
        int maior = 0;
        int menor = 0;
        for (int i = 0; i <= 4; i++)
        {
            Console.Write("Numero  .: ");
            vetor[i] = int.Parse(Console.ReadLine());
            if (vetor[i]==1)
            {
                maior = vetor[i];
                menor = vetor[i];
            }

            if  (vetor[i]> maior)
            {
                maior = vetor[i];
            }
            if (vetor[i]< menor)
            {
                menor = vetor[i];
            }

         
        }
        Console.WriteLine("Maior numero foi .: " + maior);
        Console.Write("");
        Console.Write("Menor numero foi .: " + menor);
    }
}


