using System;

class Program
{
    static string DecodificarLinguaP(string msg)
    {
        string resultado = "";

        for (int i = 0; i < msg.Length; i++)
        {
            if (msg[i] == ' ')
            {
                resultado += ' ';
            }
            else if (msg[i] == 'p' || msg[i] == 'P')
            {
                if (i + 1 < msg.Length)
                {
                    resultado += msg[i + 1];
                    i++;
                }
            }
        }

        return resultado;
    }

    static void Main()
    {
        Console.Write("Digite a mensagem em Lingua do P: ");
        string mensagem = Console.ReadLine();

        string mensagemDecodificada = DecodificarLinguaP(mensagem);

        Console.WriteLine("\nMensagem original: " + mensagem);
        Console.WriteLine("Mensagem decodificada: " + mensagemDecodificada);
    }
}