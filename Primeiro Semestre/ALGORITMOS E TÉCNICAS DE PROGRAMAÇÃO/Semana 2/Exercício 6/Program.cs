//Faça umprograma que receba as três notas, calcule e mostre a média ponderada e o conceito que segue a tabela:
using System;

class Program
{
    static void Main()
    {
        double trabalho, avaliacao, exame, media;
        string conceito;

        Console.WriteLine("esse programa calcula a media das notas e o conceito do aluno.");
        Console.Write("informe a nota do trabalho de laboratorio: ");
        trabalho = double.Parse(Console.ReadLine());
        Console.Write("informe a nota da avaliacao semestral: ");
        avaliacao = double.Parse(Console.ReadLine());
        Console.Write("informe a nota do exame final ");
        exame = double.Parse(Console.ReadLine());

        media = (trabalho * 0.2) + (avaliacao * 0.3) + (exame * 0.5);

        if (media >= 8 && media <= 10)
            conceito = "A";

        else if (media >= 7 && media < 8)
            conceito = "B";

        else if (media >= 6 && media < 7)
            conceito = "C";

        else if (media >= 5 && media < 6)
            conceito = "D";

        else  conceito = "E";


        Console.WriteLine($"media: {media}.");
        Console.WriteLine($"conceito: {conceito}.");

    }
}
