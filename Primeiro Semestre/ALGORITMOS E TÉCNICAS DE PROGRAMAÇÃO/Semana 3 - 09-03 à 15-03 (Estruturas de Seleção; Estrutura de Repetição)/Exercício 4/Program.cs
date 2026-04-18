//Um programa deverá prover ao usuário um menu de opções de conversão para medida
using System;
class Program
{
    static void Main()
    {
        int opcao;
        double medida, conversao;

        Console.WriteLine("esse programa é um conversor de medidas.");
        Console.WriteLine("digite 1 para converter Quilometros para Milhas.");
        Console.WriteLine("digite 2 para converter Metros para Pés.");
        Console.WriteLine("digite 3 para converter Célsius para Farenheit.");
        Console.WriteLine("digite 4 para converter Quilogramas para Libras.");
        Console.Write("digite a opção desejada [1, 2, 3, 4]: ");
        opcao = int.Parse(Console.ReadLine());      
        
       

        switch (opcao)
        {
            case 1 : 
                Console.Write("informe a distância [Km]: ");
                medida = double.Parse(Console.ReadLine());
                conversao = medida * 0.62;
                Console.WriteLine($"{medida} KM = {conversao} Milhas.");
                break;

            case 2 : 
                Console.Write("informe a medida [Metros]: ");
                medida = double.Parse(Console.ReadLine());
                conversao = medida * 3.28;
                Console.WriteLine($"{medida} Metros = {conversao} Pés.");
                break;

            case 3 : 
                Console.Write("informe a temperatura [Célcius]: ");
                medida = double.Parse(Console.ReadLine());
                conversao = medida * 1.8 + 32;
                Console.WriteLine($"{medida}° Célcius = {conversao}° Fahrenheit.");
                break;

            case 4 : 
                Console.Write("informe o Peso [kg]: ");
                medida = double.Parse(Console.ReadLine());
                conversao = medida * 2.20;
                Console.WriteLine($"{medida} kg = {conversao} Libras");
                break;
           
            default:
                Console.WriteLine("Opção Invalida!");
                return;
        }

        Console.WriteLine("FIM!");

    }
}

