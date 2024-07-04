//Task.Run() => Enfileira o trabalho especificado para execução no ThreadPool e retorna uma tarefa(Task) ou identificador
//Task<T> para esse trabalho

//A plataforma .NET usa um modelo unificado para cancelamento cooperativo de operações assíncronas ou síncronas de longa duração
//Este modelo é baseado em um objeto leve chamado token de cancelamento

/*
Tipos usados para realizar o cancelamento:

CancellationTokenSource - Objeto que cria um token de cancelamento, e também emite o pedido de cancelamento para todas
as cópias desse token

CancellationToken - Propaga a notificação de que as operações devem ser canceladas. Os ouvintes monitoram o valor da 
propriedade IsCancellationRequested do token por sondagem, retorno de chamada ou identificador de espera

OperationCanceledException - É a exceção que é lançada em um thread após o cancelamento de uma operação que a tarefa na 
thread estava executando
*/

/*
Padrão de implementação do Cancelamento

1 - Instancie um objeto CancellationTokenSource, que gerencia e envia notificação de cancelamento aos tokens de cancelamento
individuais 

2 - Passe o token retornado pela propriedade CancellationTokenSource.Token para cada tarefa ou thread que escuta o cancelamento

3 - Forneça um mecanismo para cada tarefa ou encadeamento para responder ao cancelamento

4 - Chame o método CancellationTokenSource.Cancel para fornecer uma notificação de cancelamento
 */

using System.Diagnostics;

var stopwatch = new Stopwatch();
stopwatch.Start();

try
{
 CancellationTokenSource cancelaTokenSource = new CancellationTokenSource();
 cancelaTokenSource?.Cancel();

 var resultado = await OperacaoLongaDuracao(100, cancelaTokenSource.Token);
 Console.WriteLine(resultado);
}
catch (Exception e)
{
 Console.WriteLine($"Tarefa cancelada: " + $"tempo expirado após {stopwatch.Elapsed} \n");
}


static Task<int> OperacaoLongaDuracao(int valor, CancellationToken cancellationToken = default)
{
 Console.WriteLine("Executou operação de longa duração");
 
 Task<int> task = null;
 //inicia a tarefa e retorna
 return Task.Run(() =>
 {
  int resultado = 0;

  //Itera o laço for
  for (int i = 0; i < valor; i++)
  {
   if (cancellationToken.IsCancellationRequested)
    throw new TaskCanceledException(task);
   //gasta o tempo
   Thread.Sleep(50);
   resultado += i;
  }

  return resultado;
 });
}

