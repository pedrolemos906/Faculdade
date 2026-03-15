// Faça um programa que receba o salário inicial de um funcionário, calcule e mostre o novo salário, acrescido de bonificação e de auxílio escola.
using System;
 class Program
{
    static void Main()
    {
        double salario, novosalario, bonus, auxilio;

        Console.WriteLine("Calculadora de Sálario.");

        Console.WriteLine("Qual o valor do sálario Bruto: ")
        salario = double.Parse(Console.ReadLine());
        
        if (salario <= 500);
            novosalario = salario + (salario *0,5);
    }


}