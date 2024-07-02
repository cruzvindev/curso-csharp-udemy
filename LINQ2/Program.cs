//Consultas LINQ - Filtrar dados 

//Where - Método de extensão que filtra uma coleção de objetos com base em uma condição
//É um extensão da interface IEnumerable<T>

using LINQ2;

var listaProdutos = Produto.GetProdutos();

Console.WriteLine("\nProdutos eletrônicos: ");
var produtoEletronicos = listaProdutos.Where(p => p.Categoria == "Eletrônicos");

foreach(var produto in produtoEletronicos)
{
    Console.WriteLine($"{produto.Nome}  \t{produto.Preco:C2}"); //C é o especificador de formato para moeda, e o número "2" é o número de casas decimais a serem exibidas
}

//filtrando com duas condições 
Console.WriteLine("\nProdutos mais caros com estoque superior a 5: ");
var produtosCarosComEstoque = listaProdutos.Where(p => p.Preco >= 2000 && p.Estoque > 5);

foreach(var produto in produtosCarosComEstoque)
{
    Console.WriteLine($"{produto.Nome}  \t{ produto.Preco:C2}  Estoque:  {produto.Estoque}");
}


//ordenando por um critério
int minimo = 10;
var produtosEstoqueMinimo = listaProdutos.Where(p => p.Estoque < minimo).OrderBy(p => p.Nome);
Console.WriteLine();
foreach (var item in produtosEstoqueMinimo)
{
    Console.WriteLine($"{item.Nome} \t Estoque:  {item.Estoque}");
}


Console.WriteLine();
//ordenando por mais de um critério
Console.WriteLine("\nProdutos ordenados por categoria e nome: ");
var produtosOrdenadosPorCategoriaENome = listaProdutos.OrderBy(p => p.Categoria).ThenBy(p => p.Nome);

string? categoriaAnterior = "";
foreach(var produto in produtosOrdenadosPorCategoriaENome)
{
    if(produto.Categoria != categoriaAnterior)
    {
        Console.WriteLine($"     {produto.Categoria}:");
        categoriaAnterior = produto.Categoria;
    }
    Console.WriteLine($"          {produto.Nome}");
}

Console.WriteLine();
Console.WriteLine("\nLista dos nomes dos produtos ordenados");

var nomesDosProdutos = listaProdutos.Select(p => p.Nome).OrderBy(nome => nome);
foreach(var produto in nomesDosProdutos)
{
    Console.WriteLine(produto);
}

//Filtrando por preço, ordenando por nome e criando um tipo anônimo 
Console.WriteLine("\nProdutos com valor menor que R$ 500 com aumento de 10% ordenados por nome");
var resultado = listaProdutos.Where(p => p.Preco < 500)
    .OrderBy(p => p.Nome)
    .Select(p => new
    {
        NomeProduto = p.Nome.ToUpper(),
        PrecoComAumento = p.Preco * 1.1
    });
                                                                                                                                 
foreach(var produto in resultado)
{
    Console.WriteLine($"{produto.NomeProduto},  \tPreço com aumento:  {produto.PrecoComAumento:C}");
}

Console.ReadKey();