//Consultas LINQ - Agrupamento
//GroupBy - Agrupa os elementos de uma sequência 

/*
 * 1 - O agrupamento é dado por um objeto IGrouping<TKey, T>
 * 2 - O TKey representa a chave do agrupamento e T é o elemento que desejamos agrupar 
 * 3 - Para uma chave composta, definimos um tipo anônimo usando a palavra-chave new 
 * 4 - Retorna um IEnumerable<IGrouping<TKey, TSource>>
 */

using LINQ4;

var listaProdutos = Produto.GetProdutos();

var produtoPorCategoria = listaProdutos.GroupBy(p => p.Categoria);

foreach(var grupo in produtoPorCategoria)
{
    Console.WriteLine(grupo.Key + " : " + grupo.Count());

    foreach(var produto in grupo)
    {
        Console.WriteLine($"  {produto.Nome}  \t{produto.Preco:C2}  \t{produto.Estoque}");
    }
}

Console.ReadKey();