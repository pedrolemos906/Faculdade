//Identificar se um ano qualquer é bissexto ou não.
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("esse programa identifica se o ano e bissexto ou nao.");
        Console.Write("informe o ano [XXXX]: ");

        int ano = int.Parse(Console.ReadLine());


        if ((ano % 4 == 0) && (ano % 100 != 0) || (ano % 400 != 0)) Console.Write(ano + " é um ano Bissexto");

        else
        { 
            Console.Write(ano + " não é um ano Bissexto");
        }

    }
}
