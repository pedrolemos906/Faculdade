using System;

class Program
{
    static void Main()
    {
        Aluno[] alunos = new Aluno[100];
        int qtAlunos = 0;

        int opcao;

        do{
            Console.WriteLine("0 - Sair");
            Console.WriteLine("1 - Cadastrar aluno");
            Console.WriteLine("2 - Listar alunos");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:

                if(qtAlunos < 100)
                {
                    Aluno novoAluno = new Aluno();

                    novoAluno.Ler();

                    alunos[qtAlunos] = novoAluno;

                    qtAlunos++;
                }
                else
                {
                    Console.WriteLine("Limite de alunos atingido.");
                }

                break;

                case 2:
                    for(int i = 0; i < qtAlunos; i++)
                    {
                        alunos[i].Escrever();
                    }

                    break;
            }
        }while(opcao != 0);     
    }
}

class Aluno
{
    private string nome;
    private double nota;
    private Data nascimento;
    private Data cadastro;

    public void SetNome(string novoNome)
    {
        nome = novoNome;
    }    
    public string GetNome()
    {
        return nome;
    }

    public void SetNota(double novaNota)
    {
        nota = novaNota;
    }
    public double GetNota()
    {
        return nota;
    }

    public void SetNascimento(Data novaData)
    {
        nascimento = novaData;
    }
    public Data GetNascimento()
    {
        return nascimento;
    }

    public void SetCadastro(Data novoCadastro)
    {
        cadastro = novoCadastro;
    }
    public Data GetCadastro()
    {
        return cadastro;
    }

    public void Ler()
    {
        Console.Write("Nome: ");
        nome = Console.ReadLine();

        do{
            Console.Write("Nota: ");
            nota = double.Parse(Console.ReadLine());

            if (nota < 0 || nota > 100)
            {
                Console.WriteLine("Nota inválida.");
            }

        } while (nota < 0 || nota > 100);

        nascimento = new Data();
        cadastro = new Data();

        Console.WriteLine("Data de Nascimento: ");
        nascimento.Ler();

        Console.WriteLine("Data de Cadastro: ");
        cadastro.Ler();
    }

    public void Escrever()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Nota: " + nota);

        Console.Write("Nascimento: ");
        nascimento.Escrever();

        Console.Write("Cadastro: ");
        cadastro.Escrever();
    }
}
 class Data
{
    private int dia;
    private int mes;
    private int ano;

    public void SetDia(int novodia)
    {
        dia = novodia;
    }
    public int GetDia()
    {
        return dia;
    }

    public void SetMes(int novoMes)
    {
        mes = novoMes;
    }
    public int GetMes()
    {
        return mes;
    }

    public void SetAno(int novoAno)
    {
        ano = novoAno;
    }
    public int GetAno()
    {
        return ano;
    }

    public void Ler()
    {
        Console.Write("Dia: ");
        dia = int.Parse(Console.ReadLine());
        Console.Write("Mês: ");
        mes = int.Parse(Console.ReadLine());
        Console.Write("Ano: ");
        ano = int.Parse(Console.ReadLine());
    }

    public void Escrever()
    {
        Console.WriteLine($"{dia}/{mes}/{ano}");
    }

}

