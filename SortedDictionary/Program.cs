//A SortedDictionary é uma coleção genérica que armazena dados no formato chave/valor de forma ordenada onde a ordenação é feita pela chave
//As chaves dessa coleção devem ser EXCLUSIVAS e NÃO NULAS 
//Essa coleção aumenta seu tamanho automaticamente à medida que adicionamos pares chave/valor à coleção
//Essa classe usa uma árvore binária para manter os itens em ordem pela chave, com isso o tipo usado para a
//chave deve implementar a interface IComparable<TKey> de modo que as chaves possam ser corretamente ordenadas 

//As chaves não precisam ser inclusas em uma ordem, mas devem ser distintas entre si

var brics = new SortedDictionary<int, string>()
{
    {20, "Brasil" },
    {10, "China"},
    {40, "India" },
    {30, "URSS" }
};

Console.WriteLine("\nIncluindo o elemento de chave = 70 e valor = Bélgica");
if (brics.ContainsKey(70)) //Verifico se a chave já existe, pois se já existir e eu tentar adicionar novamente uma exceção será lançada
{
    Console.WriteLine("Chave já existe");
}
else
{
    brics.Add(70, "Bélgica");
}

Console.WriteLine($"\nNúmero de pares de chaves(elementos) no dicionário : {brics.Count}");

Console.WriteLine("\nAcessando um elemento pela chave -> brics[20]");
Console.WriteLine($"Chave 20 -> {brics[20]}");

brics[20] = "Argentina"; //Alterando valor do elemento de chave 20

brics.Remove(10);

if(brics.TryGetValue(30, out string? valor))
{
    Console.WriteLine($"Valor da chave 30 : {valor}");
} else
{
    Console.WriteLine("A chave não existe");
}

foreach (var pais in brics)
{
    Console.WriteLine($"Chave/Valor = {pais.Key} {pais.Value}");
}