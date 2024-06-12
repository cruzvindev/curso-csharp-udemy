//No C# temos 2 tipos de conjuntos: HashSet e SortedSet
//HashSet<T> -> Contém uma lista não ordenada de itens distintos
//SortedSet<T> -> Contém uma lista ordenada de itens distintos
//Ambas estão presentes no namespace Syetem.Collection.Generics

//HashSet geralmente é mais rápido para operações como adicionar e remover do que SortedSet
//SortedSet é mais rápido para operações como localizar o primeiro e o último elemento do que HashSet

//HashSet implementa a interface ISet<T> que oferece métodos para criar uma união de múltiplos conjuntos, criar uma interseção de conjuntos, ou para fornecer
//informações se um conjunto for um superconjunto ou subconjunto de outro

var numeros = new HashSet<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var frutas = new HashSet<string> { "uva", "banana", "pêra" };

//contrutor de HashSet que copia os elementos de uma IEnumerable
var conjunto = new HashSet<int>(numeros);

//operações com conjuntos:
//IsSubsetOf - Indica se um objeto HashSet é um subconjunto da coleção especificada
//IsSupersetOf - Indica se um objeto HashSet é um superconjunto da coleção especificada
//Overlaps - Indica se o objeto HashSet atual e uma coleção especificada compartilham elementos em comum
//SetEquals - Indica se um objeto HashSet atual e uma coleção especificada contêm os mesmos elementos 

var timesEspanha = new HashSet<string> { "Real Madrid", "Barcelona", "Atlético de Madrid", "Real Sociedad" };
var timesInglaterra = new HashSet<string> { "Chelsea", "Liverpool", "Manchester City", "Manchester United" };
var timesAlemanha = new HashSet<string> { "Bayern de Munique", "Borussia Dortmund", "Hoffeinheim", "Leipzig" };
var timesItalia = new HashSet<string> { "Milan", "Inter de Milão", "Juventus", "Roma" };
var campeoesChampions = new HashSet<string>() { "Real Madrid", "Milan", "Bayern de Munique", "Barcelona" };

if(!timesInglaterra.Contains("West Ham"))
{
    timesInglaterra.Add("West Ham");
    timesInglaterra.Add("Liverpool");
}

if (timesEspanha.IsSubsetOf(campeoesChampions))
{
    Console.WriteLine("Times da Espanha é um subconjunto dos Campeões da Champions");
}

if (campeoesChampions.IsSupersetOf(timesEspanha))
{
    Console.WriteLine("Os maiores Campeões da Champions é um superconjunto de times da Espanha");
}

if (timesItalia.Overlaps(campeoesChampions))
{
    Console.WriteLine("Há times da Itália no conjunto de maiores campeões da Champions");
}

if (timesEspanha.SetEquals(timesItalia))
{
    Console.WriteLine("Times da Espanha e Times da Itália não possuem os mesmos elementos");
}

timesItalia.UnionWith(timesEspanha);
timesItalia.UnionWith(timesInglaterra);
timesItalia.UnionWith(timesAlemanha);

var todosTimes = new SortedSet<string>(timesItalia);

//var resultado = timesItalia.Remove("Milan");
ExibirColecao(todosTimes);

static void ExibirColecao<T>(IEnumerable<T> colecao)
{
    Console.WriteLine();
    foreach(var item in colecao)
    {
        Console.WriteLine($"{item}");
    }
}


//SORTED SET  - os métodos são basicamente os mesmos de HashSet


