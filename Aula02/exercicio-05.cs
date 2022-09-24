//Elabore um programa que tenha como parâmetros de entrada um vetor de 3 posições
//(cujos elementos são do tipo float) e forneça como saída a média aritmética dos
//números do vetor..

using System;
using System.Diagnostics.Metrics;

internal class Program
{

   private static void Main(string[] args)

    {

        float[] vetor = new float[3];
        float somaDosNumeros = 0;

        for (int i = 0; i < 3; i++)
        {
            Console.Write("Digite o numero .: " + (i) + ": ");
            vetor[i] = float.Parse(Console.ReadLine());
            somaDosNumeros += vetor[i];
        }
        Console.WriteLine("A média dos numeros digitado foi :" +(somaDosNumeros / 3));
    }
}


