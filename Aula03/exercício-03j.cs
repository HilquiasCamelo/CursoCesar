// Escreva um programa para determinar se um valor inteiro fornecido pelo usuário é
// ou não primo

using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int contador = 1;
        Console.Write("Digite um numero :");
        int numero = int.Parse(Console.ReadLine());
      

        for (int i = 1; i < numero; i++)
        {
            if (numero % i == 0)
            {
                contador = contador + 1;
            }
        }

        if (contador == 2)
            Console.WriteLine("O numero "+numero+" e primo");
        else
            Console.WriteLine("O numero "+numero+" não E primo");
    }
}