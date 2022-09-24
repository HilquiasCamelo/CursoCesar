// A tabuada de um determinado número é uma tabela de produtos deste número
// com os números de 1 a 9. Escreva um programa que peça um número ao usuário e
// imprima a tabuada deste número na tela. Caso o valor dado seja inválido o programa
// deve apenas exibir uma mensagem de aviso. Escreva um programa usando cada
// estrutura de repetição estudada.

using System;
using System.Diagnostics.Metrics;

internal class Program
{

    private static void Main(string[] args)

    {
        int numero;
        int i = 1;

        Console.Write("Digite um número aleatoriamente.: ");
        numero = int.Parse(Console.ReadLine());

        while (i < numero)
          {

            for ( i = 0; i < 10; i++)
            {
                
                Console.WriteLine(numero+"*"+i+"="+numero*i  );

            }
            i++;
        }

    }
}