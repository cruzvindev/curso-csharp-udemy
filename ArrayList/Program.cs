//ArrayList é uma coleção não genérica cujo tamanho pode ser alterado dinamicamente e que armazena elementos de vários tipos de dados
//A principal diferença para um array normal é que ArrayList não possui um tamanho fixo, sendo esse alterado dinamicamente conforme a necessidade
//ArrayList está no namespace System.Collections e possui 3 construtores usados para criar ArrayList

//ArrayList() -> Cria uma arraylist vazia e sem capacidade inicial
//ArrayList(Int32) -> É usado para criar uma instância da classe ArrayList que está vazia e tem a capacidade inicial especificada
//ArrayList(ICollection) -> É usado para criar uma arraylist inicializada com os elementos e tamanho da coleção fornecida no parâmetro

using System.Collections;

ArrayList arrayList = new(); //A capacidade sempre será o sobro do número de elementos presentes na arraylist

arrayList.Add("Vinicius");
arrayList.Add(4.5);
arrayList.Add(true);
arrayList.Add(null);
//ou
var lista = new ArrayList() { "Paulo", 4.5, 5, true, " ", null };

lista.AddRange(arrayList); //Adiciona os elementos de uma colecção no final da coleção que está invocando o método
lista.InsertRange(1, arrayList);//Adiciona os elementos de uma coleção a partir de uma determinada posição de outra coleção
lista.Remove(null);
lista.RemoveAt(0);
lista.RemoveRange(1, 3); //Remove 3 elementos a partir da posição 1
lista.Contains("Paulo"); //retorna true ou false se contem o elemento


var nomes = new ArrayList() { "Vinicius", "João", "Ana", "Luan", "Chris" };
nomes.Sort();//vai ordenar os elementos em ordem ascendente utilizando o QuickSort
nomes.Clear();//esvazia a lista

//ArrayList é bem antiga na linguagem e foi projetada para armazenas coleções heterogêneas de objetos. Nesse sentido, ArrayList armazena os elementos como Object
//e portanto precisa converter o tipo valor armazenado para object(boxing) o que pode não oferecer o melhor desempenho

//A recomendação portanto é utilizar a coleção List<Object> para objetos de natureza diferente e List<T> para armazenar objetos de um mesmo tipo
