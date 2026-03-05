using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Par ou Impar");
        Console.Write("Digite um inteiro: ");

        int x = int.Parse(Console.ReadLine());

        int resto = x % 2 ;

        if (resto == 0) Console.Write("Par!");

        else
        {
            Console.Write("Impar!");
        }        
    }
}