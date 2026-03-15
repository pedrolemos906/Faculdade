// Faça uma calculadora
using System;

class Program
{
    static void Main()
    {

        double num1, num2, resultado;

        Console.WriteLine("Calculadora");

        Console.Write("Escolha o 1º algarismo: ");
        num1 = double.Parse(Console.ReadLine());

        Console.Write("Escolha o 2º algarismo: ");
        num2 = double.Parse(Console.ReadLine());

        //operador
        Console.WriteLine("'+' para somar");
        Console.WriteLine("'-' para subtrair");
        Console.WriteLine("'*' para multiplicar");
        Console.WriteLine("'/' para dividir");
        Console.Write("Escolha o operador: ");
        char operador = char.Parse(Console.ReadLine());

        switch (operador)
        {
            case '+' : resultado = num1 + num2;
                break;
            case '-' : resultado = num1 - num2;
                break;
            case '*' : resultado = num1 * num2;
                break;
            case '/' : resultado = num1 / num2;
                break;
            default: Console.Write("Operador inválido!");
                break;
        }

        Console.Write("O resultado da Operação é " + resultado);
    }
}
