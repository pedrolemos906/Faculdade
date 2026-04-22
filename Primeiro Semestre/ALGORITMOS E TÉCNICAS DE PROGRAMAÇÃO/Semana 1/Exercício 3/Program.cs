//Calcular e escrever o perímetro e a área de um quadrado.
using System;
using System.Formats.Asn1;
class Progam
{
    static void Main()
    {
        double lado, perimetro, area;

        Console.WriteLine("esse programa calcula o perimetro e a area de um quadrado.");
        Console.Write("digite um dos lados do quadrado: ");
        lado = int.Parse(Console.ReadLine());

        perimetro = lado * 4;

        area = lado * 2;

        Console.WriteLine("o perimetro do quadrado é: " + perimetro);
        Console.WriteLine("a area do quadrado é: " + area);

    }
}

