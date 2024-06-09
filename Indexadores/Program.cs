//Um indexador permite que você acesse os elementos de um objeto da mesma forma que você acessaria os elementos de um array, usando a sintaxe de colchetes [].


SimpleCollection collection = new SimpleCollection();

// Usando o indexador para definir valores
collection[0] = 1;
collection[1] = 2;

// Usando o indexador para acessar valores
Console.WriteLine(collection[0]); // Saída: 1
Console.WriteLine(collection[1]); // Saída: 2


public class SimpleCollection
{
    private int[] data = new int[10]; // Array interno para armazenar dados

    // Definição do indexador
    public int this[int index]
    {
        get { return data[index]; }  // Obter valor no índice especificado
        set { data[index] = value; } // Definir valor no índice especificado
    }
}
