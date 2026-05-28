//5. Considere uma turma com N alunos, sendo N um valor lido. Para cada aluno, ler a nota obtida em uma avaliação de valor igual a 100 – rejeitar a leitura de valores fora do domínio forçando uma nova leitura. Ao final das leituras, calcular e escrever a nota média da turma, o número de alunos com nota superior à nota média da turma, a amplitude das notas (a diferença entre a maior e a menor nota obtida).
using System;



class Program
{
    static void Main()
    {

        double[] vetorNotas = new double[100];

        Console.WriteLine("Vetor de notas.");

        int qtAlunos = inserirNotas(vetorNotas);

        double media = mediaNotas(vetorNotas, qtAlunos);

        int alunosAcimaDaMedia = buscarAcimaDaMedia(vetorNotas, qtAlunos, media);

        double maior = buscarMaiorNota(vetorNotas, qtAlunos);

        double menor = buscarMenorNota(vetorNotas, qtAlunos);

        double amplitude = maior - menor;

        double aprovados = (buscarAprovados(vetorNotas, qtAlunos) / qtAlunos) * 100;

        double menorNotaAprovados = buscarMenorNotaAprovados(vetorNotas, qtAlunos, aprovados);

        for (int i = 0; i < qtAlunos; i++)
        {
            Console.WriteLine($"Aluno {i + 1} = {vetorNotas[i]}");
        }

        Console.WriteLine($"Media da turma: {media}");
        Console.WriteLine($"Quantidade de aluno acima da media:  {alunosAcimaDaMedia}");
        Console.WriteLine($"Amplitude das notas: {amplitude}");
        Console.WriteLine($"Percentual de alunos aprvado: {aprovados}%");
        Console.WriteLine($"Menor nota entre os aprovados: {menorNotaAprovados}");

    }

    static int inserirNotas(double[] vetorNotas)
    {
        double nota;
        int cont = 0;

        while (cont < 100)
        {

            Console.Write($"informe a nota do {cont + 1}º aluno: ");
            nota = double.Parse(Console.ReadLine());
            if (nota < 0)
            {
                break;
            }
            else if (nota >= 0 && nota <= 100)
            {
                vetorNotas[cont] = nota;
                cont = cont + 1;
            }

            else
            {
                Console.WriteLine("nota inválida.");
            }

        }
        return cont;
    }


    static double mediaNotas(double[] vetorNotas, int qtAlunos)
    {
        double soma = 0;
        for (int x = 0; x < qtAlunos; x++)
        {
            soma = soma + vetorNotas[x];
        }
        double media = soma / qtAlunos;

        return media;
    }

    static int buscarAcimaDaMedia(double[] vetorNotas, int qtAlunos, double media)
    {
        int qtAlunosAcimaDaMedia = 0;
        double regra = media;

        for (int x = 0; x < qtAlunos; x++)
            if (vetorNotas[x] > regra)
            {
                qtAlunosAcimaDaMedia = qtAlunosAcimaDaMedia + 1;
            }

        return qtAlunosAcimaDaMedia;
    }

    static double buscarMaiorNota(double[] vetorNotas, int qtAlunos)
    {
        double maior = vetorNotas[0];

        for (int x = 0; x < qtAlunos; x++)
            if (maior < vetorNotas[x])
            {
                maior = vetorNotas[x];
            }


        return maior;
    }

    static double buscarMenorNota(double[] vetorNotas, int qtAlunos)
    {
        double menor = vetorNotas[0];
        for (int x = 0; x < qtAlunos; x++)
            if (menor > vetorNotas[x])
            {
                menor = vetorNotas[x];
            }


        return menor;
    }

    static double buscarAprovados(double[] vetorNotas, int qtAlunos)
    {
        double aprovados = 0;
        for (int x = 0; x < qtAlunos; x++)
        {
            if (vetorNotas[x] >= 60)
            {
                aprovados = aprovados + 1;
            }
        }

        return aprovados;
    }

    static double buscarMenorNotaAprovados(double[] vetorNotas, int qtAlunos, double aprovados)
    {
        double menorNotaAprovados = 100;
        if (aprovados == 0)
        {
            menorNotaAprovados = 0;
        }
        for (int x = 0; x < qtAlunos; x++)
        {
            if (vetorNotas[x] >= 60 && vetorNotas[x] < menorNotaAprovados)
            {
                menorNotaAprovados = vetorNotas[x];
            }


        }

        return menorNotaAprovados;
    }

}