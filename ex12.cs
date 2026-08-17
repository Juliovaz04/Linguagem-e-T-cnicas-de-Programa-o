using System;
using System.Globalization;

class Program
{
    static double CalcularNotaFinal(double[] notas)
    {
        Array.Sort(notas);
        return notas[1] + notas[2] + notas[3];
    }

    static void Main()
    {
        string[] entrada = Console.ReadLine().Split(' ');
        double[] notas = new double[5];

        for (int i = 0; i < 5; i++)
        {
            notas[i] = double.Parse(entrada[i], CultureInfo.InvariantCulture);
        }

        double notaFinal = CalcularNotaFinal(notas);
        Console.WriteLine(notaFinal.ToString("F1", CultureInfo.InvariantCulture));
    }
}