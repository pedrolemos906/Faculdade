// Faça um programa que Solicite ao usuário um valor inteiro e positivo. Informe a ele se o número fornecido é um número primo ou não.
using System;

class program
{
    static void Main()
    {
    
        int  n, x;
        bool primo = true;
        

        Console.WriteLine("esse programa identifica se o numero é primo.");
        Console.Write("Informe o numero que deseja testar: ");
        x = int.Parse(Console.ReadLine());


        for (n = 2; n < (x / 2); n++)
        {
            if (x % n == 0)
            {
                primo = false;
                break;    
            }
        }

        if (primo && x != 1)
            Console.WriteLine(" é primo");

        else Console.WriteLine("não é primo");       
        
              
    }
}

