 using System;

class Program
{
    static char[] InverterVetor(char[] vetor)
    {
        char[] invertido = new char[vetor.Length];

        for (int i = 0; i < vetor.Length; i++)
        {
            invertido[i] = vetor[vetor.Length - 1 - i];
        }

        return invertido;
    }

    static void Main()
    {
        Console.Write("Informe uma palavra ou frase: ");
        string entrada = Console.ReadLine();

        char[] vetor = entrada.ToCharArray();

        Console.WriteLine($"\nNumero de caracteres digitados: {vetor.Length}");

        char[] resultado = InverterVetor(vetor);

        Console.WriteLine("Texto na ordem inversa: " + new string(resultado));
    }
}