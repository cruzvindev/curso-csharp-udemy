//LINQ(Language-Integrated Query) é um conjunto de tecnologias baseadas na integração de recursos de consulta diretamente na linguagem C#
//Permite escrever consultas em coleções fortemente tipadas usando palavras-chave da linguagem C#, operadores familiares e com suporte ao IntelliSense

//Os operadores de consulta padrão da LINQ são um conjunto de métodos de extensão que fornecem a funcionalidade de consulta para qualquer tipo que
//implementa IEnumerable<T> ou IQueryable<T>

//IQueryable<T> extende de IEnumerable<T> e é usada para representar coleções de objetos que podem ser consultados utilizando uma fonte de
//dados externa(banco de dados e etc)

//Temos diversos provedores da LINQ que permitem realizar consultas a partir de diversas fontes de dados (entity framework, objetos, SQl), além de podermos
//criar um provedor implementando a interface IQueryable 

//As consultas LINQ retornam os resultados como objetos 

//Definir a fonte de dados -> Definir a consulta LINQ -> Executar a consulta

//query sintax
List<string> nomes = new List<string>()
{
    "Vinicius", "João", "Eduardo", "Xavier", "Maria", "Gabriela"
};

//devolve os elementos filtrados
var resultado = from nome in nomes
                where nome.Contains('o')
                select nome;

//method sintax
var result = nomes.Where(m => m.Contains('o'));

//Ambos os resultados são um IEnumerable<string>

//As consultas LINQ só são executadas de fato quando seu valor é realmente necessário(foreach, Count, Sum e etc),
//esse comportamento é chamado de Deferred Execution

//IEnumerable<T> é uma interface que define um contrato para uma coleção de objetos que pode ser enumerada sequencialmente mas não pode ser alterada

//List<T> é uma implementação concreta de uma coleção de objetos que é armazenada em memória e pode ser acessada e modificada de forma eficiente
//podendo ser alterada e ordenada 


