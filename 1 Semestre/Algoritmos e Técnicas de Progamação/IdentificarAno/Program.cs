using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Identificador do Ano!");
        Console.Write("Informe o ano [XXXX]: ");

        int ano = int.Parse(Console.ReadLine());

        int regra1 = ano % 400;

        int regra2 = ano % 100;

        int regra3 = ano % 4;

        if ((regra3 == 0) && (regra2 != 0) || (regra1 != 0)) Console.Write(ano + " é um ano Bissexto");

        else
        { 
            Console.Write(ano + " não é um ano Bissexto");
        }

    }
}
