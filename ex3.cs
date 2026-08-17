 using System;

class Program
{
    static double MaiorElemento(double[] vetor)
    {
        double maior = vetor[0];

        for (int i = 1; i < vetor.Length; i++)
        {
            if (vetor[i] > maior)
            {
                maior = vetor[i];
}
}

        return maior;
}

    static void Main()
    {
        Console.Write("Informe a quantidade de elementos do vetor: ");
        int n = int.Parse(Console.ReadLine());

        double[] vetor = new double[n];

        Console.WriteLine("Informe os numeros do vetor:");

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Elemento {i}: ");
            vetor[i] = double.Parse(Console.ReadLine());
}

        Console.WriteLine("\nVetor:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(vetor[i] + " ");
}

        double maior = MaiorElemento(vetor);

        Console.WriteLine($"\n\nMaior elemento do vetor e = {maior}");
}
}