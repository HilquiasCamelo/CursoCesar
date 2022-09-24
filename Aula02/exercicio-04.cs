//A empresa Lucro Certo paga R$ 10,00 por hora normal trabalhada, e R$ 15,00 por hora
//extra. Faça um programa para calcular e imprimir o salário bruto e o salário líquido de
//um determinado funcionário. Considere que o salário líquido é igual ao salário bruto
//descontando-se 10% de impostos.

using System;
using System.Diagnostics.Metrics;

internal class Program
{

    private static void Main(string[] args)
    {

        Console.WriteLine("Olá !! ? ");
        Console.WriteLine("Vamos calcular os salarios do funcionários");
        Console.Write("Digite o nome do funcionário: ");
        String nomeFuncionario = Console.ReadLine();

        Console.Write("Qual foi a jornada de trabalho ? , digite quantidade de horas:");
        double jornadaTrabalho = double.Parse(Console.ReadLine());

        Console.Write("Houveram jornadas extras , se sim, digite quantidade de horas:");
        double horaExtras = double.Parse(Console.ReadLine());


        double salarioBruto = (jornadaTrabalho * 10.00) + (horaExtras * 15.00);
        double salarioLiquido = salarioBruto - (salarioBruto * 0.1);

        Console.WriteLine("O salário bruto do funcionario :" + nomeFuncionario + " será de " + salarioBruto);
        Console.WriteLine("O salário liquido do funcionario :" + nomeFuncionario + " será de " + salarioLiquido);
    }
}


