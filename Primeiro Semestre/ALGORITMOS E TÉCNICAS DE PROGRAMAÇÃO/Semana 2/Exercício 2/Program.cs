//Em um único algoritmo: Calcular o peso ideal de um homem, sabendo que: Peso Ideal de pessoas de gênero masculino:  (72.7  x  altura) – 58 Calcular o peso ideal de uma mulher, sabendo que: Peso Ideal de pessoas de gênero feminino:  (62.1  x  altura) – 44.7
using System;
class Program
{
    static void Main()
    {
        char sexo;
        double altura, pesoideal;

        Console.WriteLine("esse programa calcula o peso ideal para um homem e para uma mulher.");

        Console.Write("informe se voce e um homem ou uma mulher [H/M]: ");
        sexo = char.Parse(Console.ReadLine());

        Console.Write("informe sua altura em metros: ");
        altura = double.Parse(Console.ReadLine());

        if (sexo == 'H' || sexo == 'h')
        {   
            pesoideal = (72.7 * altura) - 58;
            Console.WriteLine("o seu peso ideal é: " + pesoideal);
        }

        else
        {
            pesoideal = (62.1 * altura) - 44.7;
            Console.WriteLine("o seu peso ideal é: " + pesoideal);            
        }
                   
    }
}

