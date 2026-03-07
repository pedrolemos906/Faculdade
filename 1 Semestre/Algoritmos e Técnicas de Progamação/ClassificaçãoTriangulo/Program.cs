// crie um programa em c# para ler três lados de um triângulo e, sendo ele válido, identificar o seu tipo: equilátero, isóscele ou escaleno. Caso não lembre, busque se informar quais as condições para que três valores quaisquer permitam formar um triângulo e quais as condições a serem observadas para classificar um triângulo em um de seus três tipos:

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Idendificador de tipo de Triângulo");

        Console.Write("Digite o valor do primeiro lado do triângulo:");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Digite o valor do segundo lado do triângulo:");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Digite o valor do terceiro lado do triângulo:");
        double c = double.Parse(Console.ReadLine());

        if (a < b + c && b < a + c && c < a + b)
        {
            // Classificação
            if (a == b && b == c)
            {
                Console.WriteLine("Triângulo Equilátero");
            }
            else if (a == b || b == c || a == c)
            {
                Console.WriteLine("Triângulo Isósceles");
            }
            else
            {
                Console.WriteLine("Triângulo Escaleno");
            }
        }
        else
        {
            Console.WriteLine("Os valores informados não formam um triângulo válido.");
        }
    }
}

