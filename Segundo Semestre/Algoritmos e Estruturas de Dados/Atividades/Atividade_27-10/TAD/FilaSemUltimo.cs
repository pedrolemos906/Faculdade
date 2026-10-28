public class FilaSemUltimo
{
    private Celula primeiro = new Celula();
    public long passos = 0;   // quantas células o inserir visitou

    public void inserir(int x)
    {
        Celula tmp = new Celula(x);
        Celula i = primeiro;
        while (i.prox != null)
        {
            i = i.prox;
            passos++;
        }
        i.prox = tmp;
    }
}