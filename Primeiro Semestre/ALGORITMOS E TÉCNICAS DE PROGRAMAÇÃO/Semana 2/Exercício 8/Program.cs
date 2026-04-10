// Faça um programa que receba o salário inicial de um funcionário, calcule e mostre o novo salário, acrescido de bonificação e de auxílio escola.
using System;
 class Program
{
    static void Main()
    {
        double salario, salarioBonus = 0, salarioEscola = 0, novoSalario = 0;

        Console.WriteLine("Calculadora de Sálario.");

        Console.Write("Qual o valor do sálario Bruto: R$ ");
        salario = double.Parse(Console.ReadLine());


        // bonus 
        if (salario <= 500)
            salarioBonus = salario + (salario * 0.05);

        else if (salario > 500 && salario < 1200)
            salarioBonus = salario + (salario * 0.12);
                
        else 
            salarioBonus = salario;

        // auxilio creche
        if (salario <= 600)
            salarioEscola = 150;

        else if (salario > 600)
            salarioEscola = 100;
                
                

        novoSalario = salarioBonus + salarioEscola;

        Console.WriteLine("O salario total do funcionario é: R$ " + novoSalario);


    }


}
