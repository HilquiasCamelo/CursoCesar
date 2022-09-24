// No ensino público, normalmente as notas são dadas através de conceitos (A, B, C,
// D, E). Elabore um programa que leia uma nota numérica de 0 a 10 e exiba o conceito
// relativo a esta nota, conforme tabela abaixo.
// Nota Conceito:
// De 0.0 à 1.9 E
// De 2.0 à 4.9 D
// De 5.0 à 6.9 C
// De 7.0 à 8.9 B
// De 9.0 à 10.0 A


using System;
using System.Diagnostics.Metrics;

internal class Program
{

    private static void Main(string[] args)

    {
    
        double nota;

        {
            Console.Write("Digite as notas do aluno .: ");
            nota = int.Parse(Console.ReadLine());

            if(nota >= 0 && nota <= 1.9)
              {
                Console.Write("Conceito E");
              }
            else if (nota >= 2 && nota <= 4.9)
            {
                Console.Write("Conceito D");
            }
            else if (nota >= 5 && nota <= 6.99)
            {
                Console.Write("Conceito C");
            }
            else if (nota >= 7 && nota <= 8.99)
            {
                Console.Write("Conceito B");
            }
            else if (nota >= 9 && nota <= 10)
            {
                Console.Write("Conceito A");
            }
            else 
            {
                Console.Write("Nota invalida");
            }


        }
   }
}
