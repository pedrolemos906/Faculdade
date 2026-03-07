//Uma família desejar planejar sua viagem. A partir da distância a ser percorrida (em Km) e da velocidade média que tipicamente praticam em suas viagens (Km/h), calcule e escreva o tempo que gastarão na viagem. Lembre-se que: Distância = Tempo x Velocidade

using System;

class Program
{
    static void Main()
    {
        double distancia, velocidade, tempo;
        
        Console.WriteLine("Calcule o tempo da viagem!");

        Console.Write("Informe a distância a ser percorrida: ");
        distancia = double.Parse(Console.ReadLine());

        Console.Write("Informe a velocidade media : ");
        velocidade = double.Parse(Console.ReadLine());

        tempo = (distancia / velocidade);

        Console.Write("O tempo da viagem será de aproximadamente " + tempo + " horas!");


    }
}
