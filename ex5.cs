using System;

class Program
{
    static int acharNumeros(int[] vetor, int numero)
    {
        
        for(int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] == numero)
            {
                return i;
                // retorna posicoa de  i
            }

        }
        return -1;
        // nao esncotrou numero
    }
    static void Main()
    {
        Random random = new Random();
        Console.Write("Informe o numero de elementos do vetor : ");
        int n = int.Parse(Console.ReadLine());

        int[] vetor = new int[n];


        Console.WriteLine("\n sorteados : ");
        for (int i = 0; i < n; i++)
        {
            
            vetor[i] = random.Next(1,100);
            Console.Write(vetor[i] + " ");

        }
        Console.Write("\n Informe numero para encontrar");
         int numero = int.Parse(Console.ReadLine());

         int posicao = acharNumeros( vetor, numero);


         if(posicao != -1)
        {
            
            Console.WriteLine($"o numero {numero} esta na posicao {posicao}");

        }
        else
        {
            Console.WriteLine($"o numero, infelizmente, nao foi encontrado no vetor");



        }
    }
}