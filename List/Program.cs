//List<T> é uma coleção de objetos fortemente tipados que podem ser acessados usando um índice que inicia em zero, e possui métodos para manipulas seus dados
//Essa coleção é a versão genérica da coleção ArrayList, sendo equivalente a ela, e está presente no namespace System.Collections.Generic
//Por conter elementos de um determinado tipo, List<T> fornece verificação em tempo de compilação e não executa boxing-unboxing 

List<string> minhaLista = new List<string>() { "Olá", "meu", "nome", "é", "vinicius" };
List<string> outraLista = new();

outraLista.Add("oi");

string[] array1 = new string[2]{"João", "Pedro"};
outraLista.AddRange(array1);
outraLista.InsertRange(0, array1);
outraLista.RemoveRange(0, 3); //remove um número de elementos a partir de um índice

//podemos acessar valores de uma lista pelo seu índice também 

var valor1 = minhaLista[0];
minhaLista[0] = "oi";

foreach (var item in outraLista)
{
    Console.WriteLine(item);
}
minhaLista.Sort(); //retorna a lista ordenada usando o QuickSort

//Métodos de busca de List => recebem um predicado como argumento que é um método de argumento único que retorna um valor booleano

List<string> frutas = new List<string>
        {
            "Maçã",
            "Banana",
            "Laranja",
            "Uva",
            "Manga",
            "Pera",
            "Morango",
            "Abacaxi",
            "Kiwi",
            "Melancia",
            "Cereja",
            "Pêssego",
            "Ameixa",
            "Framboesa",
            "Caju"
        };

frutas.ForEach(fruta => fruta.ToLower());

Console.WriteLine("-----------------------------------------------------");
var fruta1 = frutas.Find(Procura);
Console.WriteLine(fruta1);

static bool Procura(string item)
{
    return item.Contains('n');
}

//podemos usar lambda para fornecer esse predicate 

var fruta2 = frutas.Find(f => f.Contains("am"));
Console.WriteLine(fruta2);

var fruta3 = frutas.FindLast(f => f.Contains('n'));
Console.WriteLine(fruta3);

var fruta4 = frutas.FindIndex(f => f.Contains('n'));
Console.WriteLine(fruta4);

var fruta5 = frutas.FindLastIndex(f => f.Contains('n'));
Console.WriteLine(fruta5);

var frutas6 = frutas.FindAll(f => f.Contains('n'));

//IEnumerable é uma interface que a interface IList herda e que List por sua vez implementa 