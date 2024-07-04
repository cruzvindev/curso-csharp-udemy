//Classe Semaphore - Usada para limitar o número de threads que podem ter acesso a um recurso compartilhado de forma simultânea
//Usada quando temos um número limitado de recursos e queremos limitar o número de threads que podem usar o recurso de forma simultãnea
//com a segurança da thread 

//Namespace: System.Threading 

Semaphore semaforo = new Semaphore(1, 3);

//initialCount => Número inicial de requests/entradas paea o semáforo que podem ser concedidas simultaneamente 
//maximumCount => Número máximo de request/entradas para o semáforo que podem ser concedidas simultaneamente 
Console.WriteLine("Incluiu a thread no semaforo");

//Inclui a thread no semaforo usando WaitOne
semaforo.WaitOne();

Console.WriteLine("Executou o método");

//Libera a thread do semáforo
semaforo.Release();

Console.WriteLine("Liberou a thread do semáforo");
Console.ReadLine();

//Classe SemaphoreSlim - Alternativa mais leve à classe Semaphore. Usada quando temos um número limitado de recursos e queremos
//limitar o número de threads que podem usar o recurso de forma simultãnea com a segurança da thread 

SemaphoreSlim semaforoSlim = new SemaphoreSlim(3);

//initialCount => Número inicial de requests/entradas para o semáforo que podem ser concedidas simultaneamente 
//Wait() -> Bloqueia o thread atual até que possa inserir a thread no SemaphoreSlim 
//WaitAsync() -> Aguarda assincronamente para inserir  a thread no SemaphoreSlim
//Release() -> Chamado quando uma thread for finalizada ou quando se deseja liberar a thread para que outra thread possa entrar em execução
