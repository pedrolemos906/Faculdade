using System;

class Aluno
{
    private string nome;
    private string cpf;
    private double nota;
    private Data nascimento;
    private Data cadastro;

    public static int quantidade = 0;

    public Aluno()
    {
        nascimento = new Data();
        cadastro = new Data();
    }

    public void setNome(string novoNome)
    {
        nome = novoNome;
    }

    public string getNome()
    {
        return nome;
    }

    public void setCPF(string novoCPF)
    {
        cpf = novoCPF;
    }

    public string getCPF()
    {
        return cpf;
    }

    public bool setNota(double novaNota)
    {
        if (novaNota >= 0 && novaNota <= 100)
        {
            nota = novaNota;
            return true;
        }

        return false;
    }

    public double getNota()
    {
        return nota;
    }

    public Data getNascimento()
    {
        return nascimento;
    }

    public Data getCadastro()
    {
        return cadastro;
    }

    public void setNascimento(int dia, int mes, int ano)
    {
        nascimento.setData(dia, mes, ano);
    }

    public void setCadastro(int dia, int mes, int ano)
    {
        cadastro.setData(dia, mes, ano);
    }

    public void leiaAluno()
    {
        Console.Write("Nome: ");
        nome = Console.ReadLine();

        Console.Write("CPF: ");
        cpf = Console.ReadLine();

        do
        {
            Console.Write("Nota (0 a 100): ");
            nota = double.Parse(Console.ReadLine());

        } while (!setNota(nota));

        Console.WriteLine("Data de nascimento:");
        nascimento.Ler();

        Console.WriteLine("Data de cadastro:");
        cadastro.Ler();
    }

    public void escrevaAluno()
    {
        Console.WriteLine("------------------------");
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("CPF: " + cpf);
        Console.WriteLine("Nota: " + nota);

        Console.Write("Nascimento: ");
        nascimento.Escrever();

        Console.Write("Cadastro: ");
        cadastro.Escrever();
    }
}