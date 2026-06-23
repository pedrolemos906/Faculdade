using System;

class Data
{
    private int dia;
    private int mes;
    private int ano;

    public Data()
    {
        dia = 1;
        mes = 1;
        ano = 2000;
    }

    public Data(int dia, int mes, int ano)
    {
        setData(dia, mes, ano);
    }

    public bool SetDia(int novoDia)
    {
        if (novoDia >= 1 && novoDia <= 31)
        {
            dia = novoDia;
            return true;
        }

        return false;
    }

    public int GetDia()
    {
        return dia;
    }

    public bool SetMes(int novoMes)
    {
        if (novoMes >= 1 && novoMes <= 12)
        {
            mes = novoMes;
            return true;
        }

        return false;
    }

    public int GetMes()
    {
        return mes;
    }

    public bool SetAno(int novoAno)
    {
        if (novoAno >= 0 && novoAno <= 2099)
        {
            ano = novoAno;
            return true;
        }

        return false;
    }

    public int GetAno()
    {
        return ano;
    }

    public bool setData(int novoDia, int novoMes, int novoAno)
    {
        if (SetDia(novoDia) &&
            SetMes(novoMes) &&
            SetAno(novoAno))
        {
            return true;
        }

        return false;
    }

    public bool dataValida()
    {
        if (dia >= 1 && dia <= diasMes() &&
            mes >= 1 && mes <= 12)
        {
            return true;
        }

        return false;
    }

    public int diasMes()
    {
        switch (mes)
        {
            case 2:
                return 28;

            case 4:
            case 6:
            case 9:
            case 11:
                return 30;

            default:
                return 31;
        }
    }

    public string mesExtenso()
    {
        switch (mes)
        {
            case 1: return "Janeiro";
            case 2: return "Fevereiro";
            case 3: return "Marco";
            case 4: return "Abril";
            case 5: return "Maio";
            case 6: return "Junho";
            case 7: return "Julho";
            case 8: return "Agosto";
            case 9: return "Setembro";
            case 10: return "Outubro";
            case 11: return "Novembro";
            case 12: return "Dezembro";
        }

        return "";
    }

    public void Ler()
    {
        int novoDia;
        int novoMes;
        int novoAno;

        do
        {
            Console.Write("Dia: ");
            novoDia = int.Parse(Console.ReadLine());

            Console.Write("Mes: ");
            novoMes = int.Parse(Console.ReadLine());

            Console.Write("Ano: ");
            novoAno = int.Parse(Console.ReadLine());

        } while (!setData(novoDia, novoMes, novoAno));
    }

    public void Escrever()
    {
        Console.WriteLine($"{dia}/{mes}/{ano}");
    }
}