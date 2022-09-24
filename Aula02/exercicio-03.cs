// As maçãs custam R$ 1,30 cada se forem compradas menos de uma dúzia, e R$ 1,00 se
// forem compradas pelo menos 12. Escreva um programa que leia o número de maçãs
// compradas, calcule e escreva o custo total da compra.
// using System.Diagnostics.Metrics;

using System;
using System.Diagnostics.Metrics;

internal class Program
{

    private static void Main(string[] args)
    {

        Console.Write("Quantas maças você ira levar hoje ? ");
        int totalMacas = int.Parse(Console.ReadLine());

       
         //Operador ternario
         //double  precoMaca = totalMacas < 6 ? totalMacas * 1.3 : totalMacas * 1;
         //Console.Write("Tudo bem , o preço total é : " + precoMaca);

        if (totalMacas < 6)
        {
            double precoMaca = totalMacas * 1.3;
            Console.Write("Tudo bem , o preço total é : " + precoMaca);
        }
        else
        {
            double precoMaca = totalMacas * 1;
            Console.Write("Tudo bem , o preço total é : " + precoMaca);
        }

    }
}


