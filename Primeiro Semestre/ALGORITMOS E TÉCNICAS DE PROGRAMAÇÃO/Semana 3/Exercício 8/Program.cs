// Escrever na tela do monitor de vídeo os números pares compreendidos em um intervalo fornecido pelo usuário. Para isto, solicite ao usuário os dois valores do intervalo: limite inferior (valor inicial) e limite superior (valor final).
using System;

class program
{
    static void Main()
    {
        int inicio, final, x;

        Console.WriteLine("esse programa realiza a contagem no intervalo determinado.");
        Console.WriteLine("informe o intervalo da contagem.");
        Console.Write("inicio da contagem: ");
        inicio = int.Parse(Console.ReadLine());
        Console.Write("final da contagem: ");
        final = int.Parse(Console.ReadLine());
        
        for(x = inicio; x < (final + 1); x++)
        {
            if ((x % 2) == 0) 
            {
                Console.WriteLine(x);    
            }
                
        }  
    }
}

