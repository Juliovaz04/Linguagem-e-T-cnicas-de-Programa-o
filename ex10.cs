using System;

class Program
{
    static int[] ContarFaces(int[] lancamentos)
    {
        int[] ocorrencias = new int[6];

        foreach (int resultado in lancamentos)
        {
            if (resultado >= 1 && resultado <= 6)
            {
                ocorrencias[resultado - 1]++;
            }
        }

        return ocorrencias;
    }

    static void Main()
    {
        Console.Write("Informe quantas vezes o dado sera lancado: ");
        int n = int.Parse(Console.ReadLine());

        int[] lancamentos = new int[n];

        Console.WriteLine("\nDigite os resultados obtidos (numeros de 1 a 6):");

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Lancamento {i + 1}: ");
            lancamentos[i] = int.Parse(Console.ReadLine());
        }

        int[] freq = ContarFaces(lancamentos);

        Console.WriteLine("\nQuantidade de vezes que cada face apareceu:");

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine($"Numero {i + 1}: {freq[i]} vez(es)");
        }
    }
}