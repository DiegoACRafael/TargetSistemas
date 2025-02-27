using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite uma string para inverter: ");
        string entrada = Console.ReadLine();

        string invertida = InverterString(entrada);

        Console.WriteLine($"String invertida: {invertida}");
    }

    static string InverterString(string texto)
    {
        char[] caracteres = new char[texto.Length];
        int j = texto.Length - 1;

        for (int i = 0; i < texto.Length; i++)
        {
            caracteres[i] = texto[j];
            j--;
        }

        return new string(caracteres);
    }
}
