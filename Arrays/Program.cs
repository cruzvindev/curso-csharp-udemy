//Arrays são um conjunto de elementos de mesmo tipo de dados e de tamanho fixo
//Um array de uma dimensão é também conhecido como vetor

int[] numeros = new int[10] { 6,4,5,7,8,9,2,3,5,1 };

foreach (var i in numeros)
{
    Console.WriteLine(i);
}

//Temos a classe Array que fornece métodos para criar, manipular, pesquisar e classificar arrays, servindo assim como a classe base para os arrays 

//1 - Reverse - inverte a sequencia de um array unidimensional 
Array.Reverse(numeros);
Console.WriteLine("-----------------------------------------------");
foreach (var i in numeros)
{
    Console.WriteLine(i);
}

//2 - Sort - Ordena os itens de um array
Array.Sort(numeros);
Console.WriteLine("-----------------------------------------------");
foreach (var i in numeros)
{
    Console.WriteLine(i);
}

//3 - BinarySearch - Faz a busca em um array ordenado de um valor usando o algoritmo de busca binária. Se for encontrado será retornado o valor do índice do elemento,
//caso contrário será retornado um número negativo
Console.WriteLine("-----------------------------------------------");
var retorno = Array.BinarySearch(numeros, 1);
Console.WriteLine(retorno);