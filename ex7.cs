using System;

class Program
{
    static int ContarOcorrencias(int[] vetor, int valor)
    {
        int cont = 0;

        foreach (int elem in vetor)
        {
            if (elem == valor) cont++;
        }

        return cont;
    }

    static void Main()
    {
        Console.Write("Informe o numero de elementos do vetor: ");
        int n = int.Parse(Console.ReadLine());

        int[] vetor = new int[n];

        Console.WriteLine($"\nDigite os valores do vetor ({n} numeros):");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Valor {i + 1}: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("\nQual numero voce deseja procurar? ");
        int valorBusca = int.Parse(Console.ReadLine());

        Console.Write("\nValores informados: ");
        foreach (int elem in vetor)
        {
            Console.Write(elem + " ");
        }

        Console.WriteLine();

        int ocorrencias = ContarOcorrencias(vetor, valorBusca);

        Console.WriteLine($"\nO numero {valorBusca} foi encontrado {ocorrencias} vez(es) no vetor.");
    }
}