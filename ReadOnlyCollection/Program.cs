//As coleções somente leitura são estruturas de dados que permitem que os dados sejam acessados, mas não modificados
//Estão presentes no namespace System.Collections.ObjectModel

//ReadOnlyCollection<T> -> Fornece a classe base para uma coleção somente leitura genérica, é criada a partir de uma coleção mutável(ArrayList, List)
//ReadOnlyDictionary<TKey, TValue> ->  Representa uma coleção somente leitura genérica de pares chave/valor, é criada a partir de um dicionário mutável

//Principais métodos:
//Contains(T item) -> determina se um elemento está na coleção 
//CopyTo(T[] array, int arrayIndex) -> copia os elementos da coleção para um array unidimensional compatível, começando no índice especificado do array
//de destino
//GetEnumerator() -> retorna um enumerador que itera pela coleção
//IndexOf(T item) -> retorna o índice baseado em zero da primeira ocorrência em toda coleção
//Perceba que métodos que alteram uma coleção como Add e Remove não existem nessa classe

//Temos nas coleções genéricas o método AsReadOnly que retorna uma ReadOnlyCollection com os elementos da Collection invocadora

var planetas = new List<string> { "Terra", "Mercúrio", "Júpiter", "Netuno", "Saturno" };
var novaLista = planetas.AsReadOnly();
ExibirElementos(novaLista);

Console.WriteLine(novaLista.Contains("Júpiter") ? "sim" : "não");
Console.WriteLine(novaLista.IndexOf("Netuno"));




static void ExibirElementos<T>(IEnumerable<T> elementos)
{
    Console.WriteLine();
    foreach (var element in elementos)
    {
        Console.WriteLine(element);
    }
}