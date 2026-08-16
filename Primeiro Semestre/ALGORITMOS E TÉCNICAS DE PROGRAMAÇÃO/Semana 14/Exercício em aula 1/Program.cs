using System;
using System.IO; // necessario para usar a StreamWriter e StreamReader.
class Program
{
    static void Main()
    {
        Console.WriteLine("Arquivos!");
        string nomeArquivo = "numero.txt";

        // ler um numero pelo teclado.
        Console.Write("Digite um numero interio: ");
        int n = int.Parse(Console.ReadLine());

        // abre o arquivo para escrita (cria se não existir) e grava.
        StreamWriter escritor = new StreamWriter(nomeArquivo);
        escritor.WriteLine(n);
        escritor.Close(); // fecha o arquivo.
    }
}