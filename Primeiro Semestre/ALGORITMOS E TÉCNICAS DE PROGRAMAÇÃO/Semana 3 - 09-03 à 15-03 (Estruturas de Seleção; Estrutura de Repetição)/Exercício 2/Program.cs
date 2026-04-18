//Faça um programa que realize as quatro operaçoes básicas. 
using System;
class Program
{
    static void Main()
    {
        double a, b, resultado;
        char op;

        Console.WriteLine("esse programa é uma calculadora simples.");
        Console.Write("informe o primerio número: ");
        a = double.Parse(Console.ReadLine());
        Console.Write("informe o segundo número: ");
        b = double.Parse(Console.ReadLine());
        Console.Write("informe a operação que deseja fazer [+, -, *, /]: ");
        op = char.Parse(Console.ReadLine());

        switch (op)
        {
            case '+' : resultado = a + b;
                break;
            case '-' : resultado = a - b;
                break;
            case '*' : resultado = a * b;
                break;
            case '/' : 
                if (b != 0)
                {
                    resultado = a / b;                  
                }
                else
                {
                    Console.WriteLine("Erro: divisão por zero pode resultar em um buraco negro!!");
                    return;
                }
                break;
            default:
                Console.WriteLine("Operador invalido.");
                return;
        }

        Console.WriteLine("O resultado da operação é " + resultado);

    }
}

