TesteAsync t = new();

try
{
    t.ChamaTarefaAsync(); //Código síncrono
}
catch (Exception ex) //Não será executado pois o lançamento da exceção está fora do contexto do código síncrono(executa em outra thread)
{
    Console.WriteLine("Este bloco não será executado");
    Console.WriteLine(ex.Message);
}

Console.ReadKey();

class TesteAsync
{
    public Task MinhaTarefaAsync()
    {
        return Task.Run(() =>
        {
            Task.Delay(2000);
            throw new Exception("Minha Exception...");
        });
    }

    public async void ChamaTarefaAsync()
    {
        await MinhaTarefaAsync();
    }
}

//Para resolver isso basta mover o bloco try-catch para dentro do método assíncrono, veja:

/*
TesteAsync t = new();
t.ChamaTarefaAsync(); 
Console.ReadKey();

class TesteAsync
{
    public Task MinhaTarefaAsync()
    {
        return Task.Run(() =>
        {
            Task.Delay(2000);
            throw new Exception("Minha Exception...");
        });
    }

    public async void ChamaTarefaAsync()
    {
        try
        {
            await MinhaTarefaAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Bloco catch foi executado");
            Console.WriteLine(ex.Message);
        }
        
    }
}
*/

//Quando um código assíncrono lança uma exceção ela é armazenada no objeto Task(no estado Faulted)
//O objeto Task contém a exceção lançada na propriedade Task.Exception

//As exceções lançadas em métodos assíncronos com os tipos de retorno Task ou Task<T> são encapsuladas em uma instância da classe
//AggregateException e associadas à instância Task

//Se mais de uma exceção for lançada, todas elas serão armazenadas na coleção AggregateException.InnerExceptions

//Os métodos assíncronos com tipo de retorno void, não possuem um objeto Task associado a eles, e, assim, as exceções lançadas em um 
//método async void não podem ser capturadas fora desse método

//As tarfeas(Tasks) com falha (estado Faulted) vão lançar exceção somente quando forem aguardadas (usarem await)
