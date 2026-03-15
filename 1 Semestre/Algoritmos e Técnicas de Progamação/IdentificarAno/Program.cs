using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Identificador do Ano!");
        Console.Write("Informe o ano [XXXX]: ");

        int ano = int.Parse(Console.ReadLine());


        if ((ano % 4 == 0) && (ano % 100 != 0) || (ano % 400 != 0)) Console.Write(ano + " é um ano Bissexto");

        else
        { 
            Console.Write(ano + " não é um ano Bissexto");
        }

    }
}
