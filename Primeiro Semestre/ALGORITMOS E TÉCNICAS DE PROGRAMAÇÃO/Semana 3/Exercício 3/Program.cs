//Faça um programa que interprete um menu de restaurante onde o usuário escolhe um prato do menu e o programa exibe o nome e o preço.
using System;
class Program
{
    static void Main()
    {
        int opcao;

        Console.WriteLine("esse programa é um menu de restaurante.");
        Console.WriteLine("Escolha um item do menu:");
        Console.WriteLine("1 - Hambúrguer");
        Console.WriteLine("2 - Pizza");
        Console.WriteLine("3 - Salada");
        Console.WriteLine("4 - Refrigerante");
        Console.Write("Opção: ");
        opcao = int.Parse(Console.ReadLine());      
        
       

        switch (opcao)
        {
            case 1 : 
                Console.WriteLine("Você escolheu Hambúrguer: R$19,00");
                break;

            case 2 : 
                Console.WriteLine("Você escolheu Pizza: R$40,00");
                break;

            case 3 : 
                Console.WriteLine("Você escolheu Salada: R$18,00");
                break;

            case 4 : 
                Console.WriteLine("Você escolheu Refrigerante: R$07,00");
                break;
           
            default:
                Console.WriteLine("Opção Invalida!");
                return;
        }

        Console.WriteLine("FIM!");

    }
}

