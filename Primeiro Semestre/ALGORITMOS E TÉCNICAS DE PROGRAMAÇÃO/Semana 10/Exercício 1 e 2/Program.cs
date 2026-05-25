//1. Construa uma função que receba um valor inteiro relativo a um mês do ano [1..12]. A função deverá retornar o número de dias que o mês possui.
//2. Construa uma função que receba um valor inteiro relativo a um mês do ano [1..12]. A função deverá retornar o nome do mês por extenso.

using System;

class Program
{
     static void Main()
    {
        Console.WriteLine("Esse programa informa a quantidade de dias do mês e o nome do mês por extenso");
        Console.Write("Informe o mês desejado [de 1 à 12]: ");
        int mes = int.Parse(Console.ReadLine());
        
        string dias = qtDias(mes);

        string nome = nomeMes(mes);

        Console.Write($"{nome} tem {dias}");

    }

    static string qtDias(int mes)
    {
         switch (mes)
        {
            case 1:
                return "31 dias.";
            case 2:
                return "28 ou 29 dias, depende do ano.";
            case 3:
                return "31 dias.";
            case 4:
                return "30 dias.";
            case 5:
                return "31 dias.";
            case 6:
                return "30 dias.";
            case 7:
                return "31 dias";
            case 8:
                return "31 dias.";
            case 9:
                return "30 dias.";
            case 10:
                return "31 dias.";
            case 11:
                return "30 dias.";
            case 12:
                return "31 dias.";
            default:
                return "mes invalido.";            
        }
        
    }

    static string nomeMes(int mes)
    {
        switch (mes)
        {
            case 1:
                return "janeiro";
            case 2:
                return "fevereiro";
            case 3:
                return "março";
            case 4:
                return "abril";
            case 5:
                return "maio";
            case 6:
                return "junho";
            case 7:
                return "julho";
            case 8:
                return "agosto";
            case 9:
                return "setembro";
            case 10:
                return "outubro";
            case 11:
                return "novembro";
            case 12:
                return "dezembro";
            default:
                return "mes invalido.";            
        }
        
    }
}

   