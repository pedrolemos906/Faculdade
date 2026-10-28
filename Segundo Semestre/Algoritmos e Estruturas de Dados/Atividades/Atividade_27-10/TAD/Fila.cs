public class Fila
{
    private Celula primeiro, ultimo;

    public Fila()
    {
        primeiro = new Celula();
        ultimo = primeiro;
    }

    public bool isVazia() 
    { 
        return primeiro == ultimo; 
    }

    public int tamanho() 
    { 
        Console.WriteLine("Informe o tamanho da fila: ");
        int tamanho = int.Parse(Console.ReadLine());
        return tamanho;
    }  

    public void inserir(int x) 
    {
        ultimo.prox = new Celula(x);
        ultimo = ultimo.prox;
    }   

    public int remover()
    {
        if (primeiro == ultimo)
            throw new Exception("Erro!");
        Celula tmp = primeiro;
        primeiro = primeiro.prox;
        int elemento = primeiro.elemento;
        tmp.prox = null;
        tmp = null;
        return elemento;
    }

    public void mostrar()
    {
        for (Celula i = primeiro; i != null; i = i.prox)
        {
            Console.Write(i.elemento + " "); 
        }
    }

    
    public bool pesquisar(int x)
    {
        for (Celula i = primeiro; i != null; i = i.prox)
        {
            if (i.elemento == x)
            {
                return true;
            }
        }
        return false;
    }   
    public int maior()
    {
        int maior = int.MinValue;
        for (Celula i = primeiro; i != null; i = i.prox)
        {
            if (i.elemento > maior)
            {
                maior = i.elemento;
            }
        }
        return maior; 
    }         
    public int somar()
    {
        int soma = 0;
        for (Celula i = primeiro; i != null; i = i.prox)
        {
            soma += i.elemento;
        }
        return soma; 
    }           
    public void inverter()
    {
        Celula anterior = null;
        Celula atual = primeiro;
        Celula proximo = null;

        while (atual != null)
        {
            proximo = atual.prox;
            atual.prox = anterior;
            anterior = atual;
            atual = proximo;
        }

        ultimo = primeiro;
        primeiro = anterior;
    }         

    
    public int removerUltimo()
    {
        if (primeiro == ultimo)
            throw new Exception("Erro!");
        Celula penultimo = primeiro;
        while (penultimo.prox != ultimo)
        {
            penultimo = penultimo.prox;
        }
        int elemento = ultimo.elemento;
        penultimo.prox = null;
        ultimo = penultimo;
        return elemento; 
    }     
}

