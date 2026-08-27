namespace Atividade_de_revisão;

class Program
{
    static void Main(string[] args)
    {
        // Questão 1
        Console.WriteLine("Questão 1");
        int[] vetorQuestao1 = Questao1.criarVetor();
        Questao1.preencherVetor(vetorQuestao1);
        Questao1.deletarSextoElemento(vetorQuestao1);
        // Questão 1



        // Questão 2
        Console.WriteLine("Questão 2");
        int[] vetorQuestao2 = Questao2.criarVetor();
        Questao2.preencherVetor(vetorQuestao2);
        Questao2.buscador(vetorQuestao2);
        // Questão 2



        // Questão 3
        Console.WriteLine("Questão 3");
        int[,] matrizQuestao3 = Questao3.criarMatriz();
        Questao3.somarLinhaCinco(matrizQuestao3);
        Questao3.somarColunaQuatro(matrizQuestao3);
        Questao3.SomarTodosElementos(matrizQuestao3);
        // Questão 3



        // Questão 4
        Console.WriteLine("Questão 4");
        int[,] matriz1Questao4 = Questao4.criarMatrizAleatorias();
        int[,] matriz2Questao4 = Questao4.criarMatrizAleatorias();
        Questao4.imprimirMatriz(matriz1Questao4);
        Questao4.imprimirMatriz(matriz2Questao4);
        bool iguais = Questao4.comparadorMatriz(matriz1Questao4, matriz2Questao4);
        Questao4.imprimirResultado(iguais);
        // Questão 4


        // Questão 5
        Console.WriteLine("Questão 5");
        int[,] matrizQuestao5 = Questao5.criarMatriz();
        Questao5.imprimirMatriz(matrizQuestao5);
        Questao5.somarColuna(matrizQuestao5);
        // Questão 5
    }
}
