//Aguardar (await) a instância de Task, usando apenas o bloco try-catch vau obter apenas a primeira exceção, mesmo que várias
//exceções possam ter sido lançadas em seu método assíncrono

//Para obter todas as exceções lançadas podemos usar a propriedade InnerExceptions da classe AggregateException que representa um ou mais 
//erros que ocorrem durante a exceção do método assíncrono 

//A classe AggregateException herda a classe Exception e contém uma propriedade chamada InnerExceptions, que é uma coleção de exceções que 
//foram lançadas durante a execução asíncrona

//Assim basta iterar através das exceções individuais usando a propriedade InnerExceptions

await LancaMultiplasExcecoesAsync();

Console.ReadKey();

static async Task LancaMultiplasExcecoesAsync()
{
    Task? tarefas = null;
    try
    {
        var primeiraTask = Task.Run(() =>
        {
            Task.Delay(1000);
            throw new InvalidOperationException("InvalidOperationException lançada explicitamente");
        });
        var segundaTask = Task.Run(() =>
        {
            Task.Delay(1000);
            throw new InvalidOperationException("InvalidOperationException lançada explicitamente");
        });
        tarefas = Task.WhenAll(primeiraTask, segundaTask);
        await tarefas;
    }
    catch
    {
        Console.WriteLine("Ocorreram as seguintes exceções :-\n");
        AggregateException TodasExceptions = tarefas.Exception;

        foreach (var ex in TodasExceptions.InnerExceptions)
        {
            Console.WriteLine(ex.GetType().ToString());
        }
    }
}