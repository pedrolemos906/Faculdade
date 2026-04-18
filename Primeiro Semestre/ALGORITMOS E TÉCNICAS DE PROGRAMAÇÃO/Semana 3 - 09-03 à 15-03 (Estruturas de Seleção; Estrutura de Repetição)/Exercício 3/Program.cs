//Utilizando estrutura múltipla, construa um programa em que o usuário digite um número entre 1 e 12 e o programa escreva o nome do mês correspondente.
using System;
class Program
{
    static void Main()
    {
        int mes;
        string nome;

        Console.WriteLine("esse programa informa o nome do mês");
        Console.Write("informe o Mês [de 1 à 12]: ");
        mes = int.Parse(Console.ReadLine());
       

        switch (mes)
        {
            case 1 : nome = "Janeiro";
                break;
            case 2 : nome = "Fevereiro";
                break;
            case 3 : nome = "Março";
                break;
            case 4 : nome = "Abril";
                break;
            case 5 : nome = "Maio";
                break;
            case 6 : nome = "Junho";
                break;
            case 7 : nome = "Julho";
                break;
            case 8 : nome = "Agosto";
                break;
            case 9 : nome = "Setembro";
                break;
            case 10 : nome = "Outubro";
                break;
            case 11 : nome = "Novembro";
                break;
            case 12 : nome = "Dezembro";
                break;
            default:
                Console.WriteLine("Mês Inválido");
                return;
        }

        Console.WriteLine($"O Mês informado é {nome}");

    }
}

