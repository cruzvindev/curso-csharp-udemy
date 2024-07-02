//Consultas LINQ - Consultando elemento

//First - Retorna o primeiro elemento da sequencia ou que atenda a uma condição, se não encontrar lança uma exceção 
//FirstOrDefault - Retorna o primeiro elemento da sequência ou o elemento que atenda uma condição. Retorna o valor padrão se nenhum elemento encontrado
//Last - Retorna o último elemento da sequencia ou que atenda a uma condição, se não encontrar lança uma exceção 
//LastOrDefault - Retorna o último elemento da sequência ou o elemento que atenda uma condição. Retorna o valor padrão se nenhum elemento encontrado
//Single - Retorna o único elemento da sequência que atende a uma condição e lança uma exceção se nenhum elemento for encontrado. Lança uma exceção
//se nenhum elemento for encontrado. Lança uma exceção se houver mais de um elemento que atenda a condição
//SingleOrDefault - Retorna o único elemento da sequência que atenda uma condição ou o valor padrão se o elemento não for encontrado. Lança uma exceção se
//houver mais de um elemento que atenda a condição

using LINQ3;

var listaProdutos = Produto.GetProdutos();

Console.WriteLine("\n-First - Localiza o primeiro elemento");
var primeiroProduto = listaProdutos.First();
Console.WriteLine($"{primeiroProduto.Nome}  \t{primeiroProduto.Preco:C2}");

Console.WriteLine("\n-First - Localiza o primeiro elemento usando um critério de Nome");

try{
    var primeiraOcorrencia1 = listaProdutos.First(p => p.Nome == "Celular");
    Console.WriteLine($"{primeiraOcorrencia1.Nome}  \t{primeiraOcorrencia1.Preco:C2}");
}catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.ReadKey();
