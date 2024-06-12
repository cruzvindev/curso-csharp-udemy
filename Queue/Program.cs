//Queue é uma coleção genérica de tamanho variável que funciona com base no princípio FIFO e esta presente no namespace System.Collections.Generic
//Armazena os elementos na ordem em que forma inseridos e serão removidos nesta ordem 

string[] cursos = { "C#", "Python", "Java", "SQL", "ASP .NET" };
Queue<string> fila1 = new Queue<string>(cursos);

Console.WriteLine("Número de elementos na fila 1 : " + fila1.Count());

ExibirFila(fila1);

fila1.Enqueue(".NET MAUI");
ExibirFila(fila1);
fila1.Dequeue(); //remove o primeiro elemento da fila(C# no caso)
ExibirFila(fila1);

Console.WriteLine();
Console.WriteLine(fila1.Peek()); //devolve o primeiro elemento da fila




static void ExibirFila<T>(IEnumerable<T> elementos)
{
    Console.WriteLine();
    foreach (var item in elementos)
    {
        Console.WriteLine(item);
    }
}