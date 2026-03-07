// Faça um programa para Calcular e escrever o salário bruto de um funcionário. Dados de entrada: o número de horas trabalhadas e o valor de cada hora de trabalho.
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Calculadora de Sálario");
        Console.Write("Digite o número de horas trabalhadas:");
        double horasTrabalhadas = double.Parse(Console.ReadLine());

        Console.Write("Digite o valor de cada hora de trabalho:");
        double valorHora = double.Parse(Console.ReadLine());

        // Cálculo do salário bruto
        double salarioBruto = horasTrabalhadas * valorHora;

        // Exibição do resultado
        Console.WriteLine("O salário bruto do funcionário é: R$ " + salarioBruto);
    }
}

