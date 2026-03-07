//faça um programa em C# para  Calcular e escrever a representação em Farenheit de uma temperatura em graus celsius. Uma medida em celsius pode ser convertida em Farenheit:

using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a temperatura em graus Celsius:");

        // Leitura da temperatura em Celsius
        double celsius = double.Parse(Console.ReadLine());

        // Conversão para Fahrenheit
        double fahrenheit = celsius * 1.8 + 32;

        // Exibição do resultado
        Console.Write("A temperatura em Fahrenheit é: " + fahrenheit);
    }
}

