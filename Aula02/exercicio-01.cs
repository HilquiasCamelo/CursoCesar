//Escreva um programa que armazene o valor 10 em uma variável A e o valor 20 em
//uma variável B. A seguir (utilizando apenas atribuições entre variáveis) troque os seus
//conteúdos fazendo com que o valor que está em A passe para B e vice-versa. Ao final,
//escrever os valores que ficaram armazenados nas variáveis.

internal class Program
{
    private static void Main(string[] args)
    {
        int a, b, c;

        a = 10;
        b = 20;

        Console.WriteLine("A recebeu: " + a +" & B recebeu: " +b);
        
        c = b;
        b = a;
        a = c;
        Console.WriteLine("A passou a ser: " + a + " & B passou a ser: " + b);

    }
}