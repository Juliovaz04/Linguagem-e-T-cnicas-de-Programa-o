 using System;

class Program
{
    static int[] MulVetores(int[] vetor1, int[] vetor2)
    {
        int[] resultado = new int[vetor1.Length];

        for (int i = 0; i < vetor1.Length; i++)
        {
            resultado[i] = vetor1[i] * vetor2[i];
        }

        return resultado;
    }

    static void Main()
    {
        Console.Write("Informe o numero de posicoes dos vetores: ");
        int n = int.Parse(Console.ReadLine());

        int[] vetor1 = new int[n];
        int[] vetor2 = new int[n];

        Console.WriteLine("\nPreencha o primeiro vetor:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Digite o valor da posicao {i}: ");
            vetor1[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nPreencha o segundo vetor:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Digite o valor da posicao {i}: ");
            vetor2[i] = int.Parse(Console.ReadLine());
        }

        int[] resultado = MulVetores(vetor1, vetor2);

        Console.WriteLine("\nResultado da multiplicacao dos vetores:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(resultado[i] + " ");
        }
    }
}