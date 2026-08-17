 using System;

class Program
{
    static char[] GerarComplementar(char[] dna)
    {
        char[] comp = new char[dna.Length];

        for (int i = 0; i < dna.Length; i++)
        {
            switch (char.ToUpper(dna[i]))
            {
                case 'A': comp[i] = 'T'; break;
                case 'T': comp[i] = 'A'; break;
                case 'C': comp[i] = 'G'; break;
                case 'G': comp[i] = 'C'; break;
                default: comp[i] = dna[i]; break;
            }
        }

        return comp;
    }

    static void Main()
    {
        Console.Write("Informe a sequencia de DNA (maximo de 50 bases): ");
        string entrada = Console.ReadLine();

        if (entrada.Length > 50)
        {
            Console.WriteLine("A sequencia ultrapassou o limite de 50 caracteres.");
            return;
        }

        char[] dna = entrada.ToCharArray();
        char[] complementar = GerarComplementar(dna);

        Console.WriteLine("Sequencia complementar do DNA: " + new string(complementar));
    }
}