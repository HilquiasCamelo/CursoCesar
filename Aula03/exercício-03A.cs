//a. Ler os valores de quatro notas escolares de um aluno. Calcular a média aritmética e
//apresentar a mensagem “Aprovado” se a média obtida for maior ou igual a 5; caso
//contrário, apresentar a mensagem “Reprovado”. Informar com cada mensagem o
//valor da média obtida;

using System;
using System.Diagnostics.Metrics;

internal class Program
{

    private static void Main(string[] args)

    {

        float[] vetor = new float[4];
        float somaDosNumeros = 0;

        for (int i = 0; i < 4; i++)
        {
            Console.Write("Digite as notas do aluno .: " + (i) + ": ");
            vetor[i] = float.Parse(Console.ReadLine());
            somaDosNumeros += vetor[i];
        }
        if ((somaDosNumeros / 4) > 5)
        {
            Console.WriteLine("O aluno foi aprovado !!!");
        }
        else
        {
            Console.WriteLine("O aluno foi reprovado !!!");
        }

    }
}
