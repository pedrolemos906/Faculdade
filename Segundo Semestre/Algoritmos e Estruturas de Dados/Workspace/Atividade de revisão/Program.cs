namespace Atividade_de_revisão;

class Program
{
    static void Main(string[] args)
    {
        int[] vetor = new int[10];
        Questao1.criarVetor(vetor);
        Questao1.deletarSextoElemento(vetor);
        Questao2.criarVetor();
        Questao3.criarMatriz(new int[5, 5]);
        Questao3.somarLinhaCinco(new int[5, 5]);
        Questao3.somarColunaQuatro(new int[5, 5]);
        Questao4.criarMatrizAleatorias(new int[5, 5]);
        Questao4.criarMatrizAleatorias(new int[5, 5]);
        Questao4.comparadorMatriz(new int[5, 5], new int[5, 5]);
    }
}
