using System;
class Program
{ 
    static void Main()
    {   
        // Entrada de dados
        Console.Write("Digite a nota do Trabalho de laboratório: ");
        double lab = double.Parse(Console.ReadLine());
        Console.Write("Digite a nota da Avaliação semestral: ");
        double avaliacao = double.Parse(Console.ReadLine());
        Console.Write("Digite a nota do Exame final: ");
        double exame = double.Parse(Console.ReadLine());
        // Cálculo da média ponderada
        double media = (lab * 2 + avaliacao * 3 + exame * 5) / 10;
        // Determinação do conceito
        char conceito;
        if (media >= 8.0 && media <= 10) conceito = 'A';
            else if (media >= 7.0) conceito = 'B';
                else if (media >= 6.0) conceito = 'C';
                    else if (media >= 5.0)   conceito = 'D';
                        else conceito = 'E';
        Console.WriteLine($"Média ponderada = {media:F1}");
        Console.WriteLine($"Conceito = {conceito}");
    }
}

