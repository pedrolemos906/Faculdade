//Calcular e escrever o salário bruto de um funcionário. Dados de entrada: o número de horas trabalhadas e o valor de cada hora de trabalho.
using System;

class Progam
{
    static void Main()
    {
        double horas, valorHora, salario;

        Console.WriteLine("esse programa calcula o salario bruto de um funcionario.");

        Console.Write("digite quantas horas foram trabalhadas por esse funcionario: ");
        horas = double.Parse(Console.ReadLine());
        Console.Write("digite o valor da hora trabalhada desse funcionario: ");
        valorHora = double.Parse(Console.ReadLine());

        salario = horas * valorHora;

        Console.WriteLine("o salario bruto desse funcionario é: " + salario);
    }
}
