// Estrutura de Seleção Múltipla

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Estado civil [s/c/d/v]: ");
        char estadoCivil = char.Parse(Console.ReadLine());

        switch (estadoCivil)
        {
            case 's' : Console.Write("Solteiro");
                break;
            case 'c' : Console.Write("casado");
                break;
            case 'd' : Console.Write("divorciado");
                break;
            case 'v' : Console.Write("viúvo");
                break;

        }
        Console.Write("Fim!");
    }
}
