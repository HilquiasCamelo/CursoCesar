// Fazer um programa que dada a altura e peso de uma pessoa, calcule seu índice
// de massa corporal. Fórmula: Peso / Altura2. Em seguida, mostre em que faixa
// de peso a pessoa se encontra. Faixas: <= 18,5 - abaixo do peso normal; > 18,5 e
// <= 25 - peso normal; > 25 e <=30 - peso acima do normal; acima de 30 - peso
// excessivo.


using System;
using System.Diagnostics.Metrics;

internal class Program
{

    private static void Main(string[] args)

    {
        int peso;
        float altura, indiceMassaCorporia;

       Console.Write("Informe o peso: ");

        peso = int.Parse(Console.ReadLine());

        Console.Write("Informe a altura: ");
        altura = float.Parse(Console.ReadLine());

        indiceMassaCorporia = peso / (altura * altura);

   
       Console.Write("indiceMassaCorporia = ", indiceMassaCorporia);
        if (indiceMassaCorporia < 20)
           Console.Write(" (abaixo do peso).");
        else if ((indiceMassaCorporia >= 20) && (indiceMassaCorporia < 25))
           Console.Write(" (peso normal).");
        else if ((indiceMassaCorporia >= 25) && (indiceMassaCorporia < 30))
           Console.Write(" (acima do peso).");
        else if ((indiceMassaCorporia >= 30) && (indiceMassaCorporia < 34))
           Console.Write(" (obeso).");
        else
           Console.Write(" (muito obeso).");
    }
}
