//A programação assíncrona é um modelo de programação que permite que o aplicativo execute várias tarefas ao mesmo tempo sem
//bloquear a thread principal.

//Isso é feito usando as palavras chave async/await e a biblioteca de tarefas TPL(Task Parallel Library) do .NET

//async - indica que um método pode ser executado de forma assíncrona 
//await - indica que deve-se esperar a conclusão de uma tarefa asíncrona

//A programação assíncrona é implementada usando a classe Task do namespace System.Threading.Tasks
//A classe Task é uma representaçção assíncrona de uma operação em execução e é usada para executar tarefas assíncronas

//O núcleo da programação assíncrona são os objetos Task e Task<T>, que modelam as operações assíncronas, esses objetos
//oferecem suporte às palavras-chave async e await

//await - usado para aguardar uma operação que retorna um Task ou Task<T>
//async - usado para sinalizar que um método é assíncrono

//Task<T> -> Tipo de retorno para um método assíncrono que retorna um valor
//ex: Task<string>, Task<Produto>

//Exemplo
MeuMetodoAsync();
Console.ReadKey();
async Task MeuMetodoAsync()
{
    //Simula uma operação assíncrona que leva 1s para ser concluída 
    await Task.Delay(1000);
    Console.WriteLine("A operação assíncrona foi concluída !");
}
