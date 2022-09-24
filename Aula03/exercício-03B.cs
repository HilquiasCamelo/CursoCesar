// Ler os valores de quatro notas escolares de um aluno. Calcular a média aritmética e
// apresentar a mensagem “Aprovado” se a média obtida for maior ou igual a 7; caso
// contrário, o programa deve solicitar a nota de exame do aluno e calcular uma nova
// média aritmética entre a nota de exame e a primeira média aritmética. Se o valor
// da nova média for maior ou igual a cinco, apresentar a mensagem “Aprovado em
// exame”; caso contrário, apresentar a mensagem “Reprovado”. Informar junto com
// cada mensagem o valor da média obtida;

using System;
using System.Diagnostics.Metrics;

internal class Program
{

    private static void Main(string[] args)

    {

        float[] vetor = new float[4];
        float media = 0;
        float media2 = 0;
        float mediafinal = 0;

        for (int i = 0; i < 4; i++)
        {
            Console.Write("Digite as notas do aluno .: " + (i) + ": ");
            vetor[i] = float.Parse(Console.ReadLine());
            media += vetor[i];
        }
        if ((media / 4) >= 7)
        {
            Console.WriteLine("O aluno foi aprovado !!!");
        }

        else if((media / 4) < 7)
        {
            Console.WriteLine("");
            Console.WriteLine("O aluno foi em recuperacao !!!");
            Console.WriteLine("O digite as novas notas");
            Console.WriteLine("");

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Digite as notas do aluno .: " + (i) + ": ");
                vetor[i] = float.Parse(Console.ReadLine());
                media2 += vetor[i];
            }
            Console.WriteLine("");
            Console.WriteLine("A média da recuperação: " + media2/4);
            Console.WriteLine("");
            mediafinal = (((media + media2)/4))/2;

            Console.WriteLine("A média final foi: "+mediafinal);
            if (mediafinal >= 5) {
                Console.WriteLine("O aluno foi aprovado !!!");
            }
            else
            {
                Console.WriteLine("O aluno foi reprovado !!!");
            }
        }

    }
}

