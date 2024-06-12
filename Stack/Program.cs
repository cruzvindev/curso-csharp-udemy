//Stack<T> é uma coleção genérica de tamanho variável que funciona com base no princípio LIFO e esta presente no namespace System.Collections.Generic
//Esta coleção aceita elementos duplicados e pode aceitar null como valores
//Temos 3 contrutores: Sem parâmetros que inicia uma instância vazia e de capacidade padrão, Que recebe uma IEnumerable e copia seus elementos e um 
//que recebe um int que representa a capacidade da pilha

Stack<int> numeros = new Stack<int> ();
numeros.Push(10);
numeros.Push(10);
numeros.Push(55);
numeros.Push(72);
numeros.Push(21);
numeros.Push(8);

Console.WriteLine($"A pilha contém {numeros.Count()} elementos");

ExibirElementos(numeros);
numeros.Pop(); //remove o elemento que está no topo da pilha
ExibirElementos (numeros);
numeros.Clear ();
ExibirElementos(numeros);

static void ExibirElementos<T>(IEnumerable<T> elements)
{
    Console.WriteLine();
    foreach(var elemento in elements)
    {
        Console.WriteLine(elemento);
    }
}
