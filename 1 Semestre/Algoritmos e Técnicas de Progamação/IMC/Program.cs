//Calcular e escrever o índice de massa corporal (IMC) de uma pessoa:Índice de Massa Corporal: peso / altura2
using System;

class Program
{
    static void Main()
    {
        double peso, altura, imc;

        Console.WriteLine("Calcule seu IMC!");

        Console.Write("Informe o seu peso atual em Kg: ");
        peso = double.Parse(Console.ReadLine());

        Console.Write("Informe o sua altura em Metros [X,XX]: ");
        altura = double.Parse(Console.ReadLine());


        imc = (peso / (altura * altura));

        Console.WriteLine("Seu IMC é " + imc +"!");

    }
}
