using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("controle de truma");
        Aluno[] alunos = new Aluno[100];
        int opcao, i = 0;

        opcao = menu();
        switch (opcao)
        {
            case 0 : Console.Write("obrigado!");
                break;

            case 1 : 
        }
        
    }

    static int menu()
    {
        int op;
        do
        {
            Console.WriteLine("menu");
            Console.WriteLine("0 - sair");
            Console.WriteLine("1 - cadastrar aluno");
            Console.WriteLine("0 - listar aluno");
            Console.WriteLine("sua opção: ");
            
        }
    }
}   

class Data
{
    private int dia;
    private int mes;
    private int ano;

    public void setDia(int dia)
    {
        if (dia >= 0 && dia < 31)
        {
            this.dia = dia;
        }
    }

    public void setMes(int mes)
    {
        if (mes >= 0 && dia <= 12)
        {
            this.mes = mes;
        }
    }
    public void setAno(int ano)
    {    
        this.ano = ano;   
    }
    public void setData(int dia, int mes, int ano)
    {
        setDia(dia);
        setMes(mes);
        setAno(ano);
    }
    public void leiaData()
    {
        Console.Write("dia: ");
        int dia = int.Parse(Console.ReadLine());
        Console.Write("mes: ");
        int mes = int.Parse(Console.ReadLine());
        Console.Write("ano: ");
        int ano = int.Parse(Console.ReadLine());
        setData(dia,mes,ano);
    }
    public void escrevaData()
    {
        Console.Write(getDia() + "/" + getMes() + "/" + getAno);
    }
    public int getDia()
    {
        return dia;
    }
    public int getMes()
    {
        return mes;
    }
    public int getAno()
    {
        return ano;
    }
}// fim da class Data

class Aluno
{
    private string nome;
    private Data nascimento = new Data;

    public void setNome(string nome)
    {
        this.nome = nome;
    }
    public string getNome()
    {
        return nome;
    }
    public void leiaAluno()
    {
        Console.Write("nome: ");
        string nome = Console.ReadLine();
        nascimento.leiaData();
    }
    public void escrevaAluno()
    {
        Console.WriteLine(getNome());
        nascimento.escrevaData();
    }//fim da class aluno
}