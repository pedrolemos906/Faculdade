//Calcular e escrever a representação em Farenheit de uma temperatura em graus celsius. Uma medida em celsius pode ser convertida em Farenheit através da seguinte fórmula: Fahrenheit = celsius x 1.8 + 32 
using System;

class Progam
{
    static void Main()
    {
        double celsius, fahrenheit ;

        Console.WriteLine("esse programa converte uma temperatura em celsius para farenheit");
        Console.Write("digite a temperatura em celsius: ");
        celsius = int.Parse(Console.ReadLine());

        fahrenheit = (celsius * 1.8) + 32;

        Console.WriteLine("essa temperatura em fahrenheit é: " + fahrenheit);

    }
}
