 using System;
class Program
{
   static int SomaVetor(int[] vetor)
{
        int soma = 0;
        for (int i = 0; i < vetor.Length; i++)
{
         soma += vetor[i];
}
         return soma;
}

    static void Main()
{
        Console.Write("Informe o numero de elementos do vetor: ");
        int n = int.Parse(Console.ReadLine());
        int[] vetor = new int[n];
        Console.WriteLine("Informe numeros do vetor");
        for (int i = 0; i < n; i++)
{
            Console.Write($"Elemento {i}: ");
            vetor[i] = int.Parse(Console.ReadLine());
}

        int soma = SomaVetor(vetor);
        Console.WriteLine($"\nSoma dos elementos = {soma}");
}
}