using System;

class Program
{
    static double MenorElemento(double[] vetor)
    {
        double menor = vetor[0];

        for (int i = 1; i < vetor.Length; i++)
        {
            if (vetor[i] < menor)
            {
                menor = vetor[i];
}
}

        return menor;
}

    static void Main()
    {
        Console.Write("Informe o numero de elementos do vetor: ");
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

        double menor  = MenorElemento(vetor);

        Console.WriteLine($"\n\nMenor elemento do vetor = {menor}");
}
}