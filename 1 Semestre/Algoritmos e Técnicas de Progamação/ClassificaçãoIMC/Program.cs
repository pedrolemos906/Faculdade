// Identificar a classificação de uma pessoa quanto ao seu peso. Para isto, primeiro calcule o seu índice de massa corporal (desenvolvido na questão 3 desta lista de exercícios). Em seguida, exiba uma mensagem ao usuário conforme a tabela abaixo:

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

        if (imc < 18.5)
        {
            Console.WriteLine("Seu IMC é " + imc +" e você está ABAIXO DO PESO IDEAL!");
        }

        else if ((imc > 18.5) && (imc < 24.9))
        {
            Console.WriteLine("Seu IMC é " + imc +" e você está no PESO IDEAL!");
        }

        else if ((imc > 24.9) && (imc < 29.9))
        {
            Console.WriteLine("Seu IMC é " + imc +" e você está com SOBREPESO!");
        }

        else
        {
            Console.WriteLine("Seu IMC é " + imc +" e você está com Obesidade!");
        }

    }
}
