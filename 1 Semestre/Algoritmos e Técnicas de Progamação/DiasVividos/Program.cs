using System;
using System.Data;

class Program
{
    static void Main()
    {
        int idade, diasVividos;

        do
        {
        Console.Write("Digite sua idade: ");
        idade = int.Parse(Console.ReadLine());
        if (idade < 0 || idade >150)
            Console.WriteLine("Errado!!");
        }
        while(idade < 0 || idade > 150);

        diasVividos = idade * 365;
        Console.WriteLine("Você viveu " + diasVividos + " dias.");


    }
}
