using System;

class Program
{
    static void Main()
    {
        string texto = Console.ReadLine();

        bool resultado = EhPalindromo(texto, 0, texto.Length - 1);

        Console.WriteLine(resultado ? "SIM" : "NAO");
    }

    static bool EhPalindromo(string texto, int esquerda, int direita)
    {
        if (esquerda >= direita)
        {
            return true;
        }

        if (!char.IsLetterOrDigit(texto[esquerda]))
        {
            return EhPalindromo(texto, esquerda + 1, direita);
        }

        if (!char.IsLetterOrDigit(texto[direita]))
        {
            return EhPalindromo(texto, esquerda, direita - 1);
        }

        char a = char.ToUpper(texto[esquerda]);
        char b = char.ToUpper(texto[direita]);

        if (a != b)
        {
            return false;
        }

        return EhPalindromo(texto, esquerda + 1, direita - 1);
    }
}