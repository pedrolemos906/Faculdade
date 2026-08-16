using System;
using System.IO;
class Exemplo
{
    static void Main()
    {
        string nomeArquivo = "pessoas.txt";
        Pessoa[] vet = new Pessoa[3];

        // ler os dados das pessoas pelo teclado.
        string nome;
        int idade;
        for (int i = 0; i < vet.Length; i++)
        {
            Console.Write("Digite o nome da pessoa: ");
            nome = Console.ReadLine();
            Console.Write("Digite a idade da pessoa: ");
            idade = int.Parse(Console.ReadLine());
            vet[i].seti(idade);
        }
      
    }
}