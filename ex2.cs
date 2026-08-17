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
 
    static int ContadorImpar(int[] vetor) 
    { 
        int quantidade = 0; 
 
        for (int i = 0; i < vetor.Length; i++) 
        { 
            if (vetor[i] % 2 != 0) 
            { 
                quantidade++; 
            } 
        } 
 
        return quantidade; 
    } 
 
    static void Main() 
    { 
        Console.Write("Informe a quantidade de numeros: "); 
        int n = int.Parse(Console.ReadLine()); 
 
        int[] vetor = new int[n]; 
 
        Console.WriteLine("Agora, informe os valores do vetor:"); 
 
        for (int i = 0; i < n; i++) 
        { 
            Console.Write($"Digite o valor da posicao {i}: "); 
            vetor[i] = int.Parse(Console.ReadLine()); 
        } 
 
        int soma = SomaVetor(vetor); 
        int impar = ContadorImpar(vetor); 
 
        Console.WriteLine($"\nResultado da soma: {soma}"); 
        Console.WriteLine($"Total de numeros impares: {impar}"); 
    } 
}