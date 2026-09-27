using System;

public class Program
{
    static void Main()
    {
        int tamanhoVetor = 0;
        int tipoVetor = 0;
        int k = 0;
        int ordem = 0;
        int ordenador = 0;

        tamanhoVetor = Utilitarios.TamanhoVetor(tamanhoVetor);

        int[] vetor = new int[tamanhoVetor];

        tipoVetor = Utilitarios.TipoVetor(tipoVetor);

        Utilitarios.PreencherVetor(vetor, tipoVetor);

        Utilitarios.ExibirVetor(vetor);

        k = Utilitarios.k(k, tamanhoVetor);

        ordem = Utilitarios.Ordem(ordem, k);

        ordenador = Utilitarios.ordenador(ordenador);

        int[] novoVetor;

        switch (ordenador)
        {
            case 1:
                SelectionSortParcial.SelectionSort(vetor, k, ordem);
                novoVetor = SelectionSortParcial.SelectionSort(vetor, k, ordem);
                
                break;
            case 2:
                InsertionSortParcial.InsertionSort(vetor, k, ordem);
                novoVetor = InsertionSortParcial.InsertionSort(vetor, k, ordem);
                
                break;
            case 3:
                QuickSortParcial.QuickSort(vetor, k, ordem);
                novoVetor = QuickSortParcial.QuickSort(vetor, k, ordem);
                
                break;
            case 4:
                HeapSortParcial.HeapSort(vetor, k, ordem);
                novoVetor = HeapSortParcial.HeapSort(vetor, k, ordem);
                break;
            default:
                Console.WriteLine("Opção inválida.");
                return;
        }

        Utilitarios.ExibirVetor(novoVetor);

    }
}

