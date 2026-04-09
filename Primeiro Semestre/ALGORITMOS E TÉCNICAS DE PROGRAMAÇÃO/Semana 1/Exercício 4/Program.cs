//Calcular e escrever a área de um círculo.
using System;

class Progam
{
    static void Main()
    {
        double raio, area;

        Console.WriteLine("esse programa calcula a area de um circulo.");
        Console.Write("digite o raio do circulo: ");
        raio = int.Parse(Console.ReadLine());

        area = 3.14 * (raio * raio);

        Console.WriteLine("a area do circulo é: " + area);

    }
}
