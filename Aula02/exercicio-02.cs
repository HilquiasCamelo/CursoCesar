// Faça um programa que leia a idade de uma pessoa expressa em anos, meses e dias e
// escreva a idade dessa pessoa expressa apenas em dias. Considerar ano com 365 dias e
// mês com 30 dias.

using System.Diagnostics.Metrics;

internal class Program
{

    private static void Main(string[] args)
    {
        const int diasAno = 365;
        const int diasMes = 30;

        Console.WriteLine("Olá !!:");
        
        Console.Write("Informe a sua idade.: ");
        int anos = int.Parse(Console.ReadLine());

        Console.Write("Meses.: ");
        int meses = int.Parse(Console.ReadLine());

        Console.Write("Dias.: ");
        int dias = int.Parse(Console.ReadLine());

        dias += (anos * diasAno) + (meses * diasMes);

        Console.Write("O total de dias de sua idade s é " + dias);
    }
}


