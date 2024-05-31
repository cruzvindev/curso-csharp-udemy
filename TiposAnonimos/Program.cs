//Na versão 3.0 do C# foi introduziada a funcionalidade de tipos anônimos, que é uma classe sem nenhum nome que pode conter apenas propriedades públicas somente leitura
//O nome do tipo é gerado pelo compilador e não está disponível no código-fonte e o tipo de cada propriedade é inferido pelo compilador

//Como não há nehuma classe por trás do objeto, você deve usar a palavra-chave var ao recuperar a referência ao seu objeto
//Resumindo: O compilador cria uma classe derivada de object com um nome aleatório e os tipos de dados são inferidos

var aluno = new
{
    Nome = "Vinicius",
    Idade = 20
};

Console.WriteLine(aluno.GetType().ToString());  
Console.WriteLine(aluno.Nome + " " + aluno.Idade);

//Um tipo anônimo pode ter uma propriedade de outro tipo anônimo

var novoAluno = new
{
    Id = 1,
    Nome = "Vinicius",
    Email = "vinicius123@email.com",
    Endereco = new {Id = 1, Cidade = "João Pessoa", Estado = "Paraíba", Pais = "Brasil"}
};

Console.WriteLine(novoAluno.Endereco.Cidade);


//Podemos também criar um array de tipos anônimos 

var alunos = new[]
{
    new { Id = 1, Nome = "João", Email = "joao@email.com" },
    new { Id = 1, Nome = "Maria", Email = "maria@email.com" },
    new { Id = 1, Nome = "Ana", Email = "ana@email.com" }
};

// Os tipos anônimos sempre será local para o método no qual for definido e não pode ser retornado do método
//Pode ser passado para outro método como parâmetro de tipo de objeto, mas isso não é recomendado
//Os tipos anônimos são normalmente usados em uma cláusula Select de uma expressão de consulta, geralmente com a LINQ, para retornar um subconjunto das propriedades de 
//cada objeto na sequência de origem 