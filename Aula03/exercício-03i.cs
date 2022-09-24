// O fatorial de um número inteiro positivo é o produto dele por todos os seus
// antecessores até 1, representa-se N!. Por definição o fatorial de 0! = 1 e o fatorial
// de 1! = 1!. Exemplo: 5! = 5 * 4 * 3 * 2 * 1 = 120. Faça um programa que peça um
// número ao usuário e imprima o fatorial deste número na tela.

using System;
using System.Diagnostics.Metrics;
using System.Drawing;

internal class Program
{

    private static void Main(string[] args)

    {
        
        int resultado = 1;
        int i = 1;
        int numero;


        Console.Write("Digite um inteiro maior que 0: ");
        numero = int.Parse(Console.ReadLine());

        while (i <= numero) {
            resultado = resultado * i;
            i += 1;
        }
        Console.Write(resultado);
    }
}
