using System;
using System.IO.Pipes;
class Program
{
    static void Main()
    {
        Console.WriteLine("Identificador do Ano!");
        Console.Write("Informe o ano [XXXX]: ");

        int ano = int.Parse(Console.ReadLine());

        int regra1 = ano % 400;

        int regra2 = ano % 4;

        if (regra1 == 0) Console.Write(ano + " não é um ano Bissexto");

            if (regra2 == 0) Console.Write(ano + " não é um ano Bissexto");
            
        
        else
        { 
            Console.Write(ano + " não é um ano Bissexto");
        }



    }
}
