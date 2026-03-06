using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Calculadora do peso ideal!");

        Console.WriteLine("Informe o sexo do usuário [M/F]: ");
        char sexo = char.ToUpper(Console.ReadKey().KeyChar);

        
        Console.WriteLine("informe a altura do usuário [X,XX]: ");
        double altura = double.Parse(Console.ReadLine());

        double pesoideal = 0;

        if (sexo == 'M') pesoideal = (72.7 * altura) - 58;

        else if (sexo == 'F') pesoideal = (62.1 * altura) - 44.7;

            else Console.WriteLine("Sexo inválido. Use apenas M ou F.");

        Console.WriteLine($"O peso ideal é : {pesoideal:F2} kg");

    }
}
