using System;
using System.IO;

class Program
{
    static void Main()
    {
        Aluno[] alunos = new Aluno[100];

        int qtAlunos = 0;

        int opcao;

        do
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("1 - Salvar em Arquivo");
            Console.WriteLine("2 - Recuperar do Arquivo");
            Console.WriteLine("3 - Cadastrar aluno");
            Console.WriteLine("4 - Listar alunos");
            Console.WriteLine("5 - Pesquisar por nome");
            Console.WriteLine("6 - Aniversariantes do mês");
            Console.WriteLine("7 - Excluir por CPF");
            Console.WriteLine("8 - Excluir todos");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:

                    StreamWriter escreva = new StreamWriter("alunos.txt");

                    for (int i = 0; i < qtAlunos; i++)
                    {
                        escreva.WriteLine(
                            alunos[i].getNome() + ";" +
                            alunos[i].getCPF() + ";" +

                            alunos[i].getNascimento().GetDia() + ";" +
                            alunos[i].getNascimento().GetMes() + ";" +
                            alunos[i].getNascimento().GetAno() + ";" +

                            alunos[i].getCadastro().GetDia() + ";" +
                            alunos[i].getCadastro().GetMes() + ";" +
                            alunos[i].getCadastro().GetAno()
                        );
                    }

                    escreva.Close();

                    Console.WriteLine("Arquivo salvo.");

                    break;

                case 2:

                    if (File.Exists("alunos.txt"))
                    {
                        StreamReader ler = new StreamReader("alunos.txt");

                        qtAlunos = 0;

                        while (!ler.EndOfStream)
                        {
                            string linha = ler.ReadLine();

                            string[] campos = linha.Split(';');

                            alunos[qtAlunos] = new Aluno();

                            alunos[qtAlunos].setNome(campos[0]);
                            alunos[qtAlunos].setCPF(campos[1]);

                            alunos[qtAlunos].setNascimento(
                                int.Parse(campos[2]),
                                int.Parse(campos[3]),
                                int.Parse(campos[4])
                            );

                            alunos[qtAlunos].setCadastro(
                                int.Parse(campos[5]),
                                int.Parse(campos[6]),
                                int.Parse(campos[7])
                            );

                            qtAlunos++;
                        }

                        ler.Close();

                        Console.WriteLine("Arquivo carregado.");
                    }
                    else
                    {
                        Console.WriteLine("Arquivo não encontrado.");
                    }

                    break;

                case 3:

                    if (qtAlunos < 100)
                    {
                        alunos[qtAlunos] = new Aluno();

                        alunos[qtAlunos].leiaAluno();

                        qtAlunos++;
                    }
                    else
                    {
                        Console.WriteLine("Limite de alunos atingido.");
                    }

                    break;

                case 4:

                    if (qtAlunos == 0)
                    {
                        Console.WriteLine("Nenhum aluno cadastrado.");
                    }

                    for (int i = 0; i < qtAlunos; i++)
                    {
                        alunos[i].escrevaAluno();
                    }

                    break;

                case 5:

                    Console.Write("Nome para pesquisa: ");
                    string nome = Console.ReadLine();

                    bool encontrou = false;

                    for (int i = 0; i < qtAlunos; i++)
                    {
                        if (alunos[i].getNome()
                            .ToUpper()
                            .Contains(nome.ToUpper()))
                        {
                            alunos[i].escrevaAluno();

                            encontrou = true;
                        }
                    }

                    if (!encontrou)
                    {
                        Console.WriteLine("Aluno não encontrado.");
                    }

                    break;

                case 6:

                    Console.Write("Mês: ");
                    int mes = int.Parse(Console.ReadLine());

                    encontrou = false;

                    for (int i = 0; i < qtAlunos; i++)
                    {
                        if (alunos[i].getNascimento().GetMes() == mes)
                        {
                            alunos[i].escrevaAluno();

                            encontrou = true;
                        }
                    }

                    if (!encontrou)
                    {
                        Console.WriteLine("Nenhum aniversariante encontrado.");
                    }

                    break;

                case 7:

                    Console.Write("CPF: ");
                    string cpf = Console.ReadLine();

                    bool removido = false;

                    for (int i = 0; i < qtAlunos; i++)
                    {
                        if (alunos[i].getCPF() == cpf)
                        {
                            for (int j = i; j < qtAlunos - 1; j++)
                            {
                                alunos[j] = alunos[j + 1];
                            }

                            qtAlunos--;

                            removido = true;

                            break;
                        }
                    }

                    if (removido)
                    {
                        Console.WriteLine("Aluno removido.");
                    }
                    else
                    {
                        Console.WriteLine("CPF não encontrado.");
                    }

                    break;

                case 8:

                    qtAlunos = 0;

                    Console.WriteLine("Todos os alunos foram removidos.");

                    break;
            }

        } while (opcao != 0);
    }
}