//O C# possui delegates pré-definidos que podemos usar para passar referências a métodos como argumentos para outros métodos como argumentos
//para outros métodos 

//Predicate<T> - Representa um método que recebe um único argumento do tipo T e retorna um valor booleano. Pode ser usado para testar se um objeto
//satisfaz uma condição específica

//Action<T> - Representa um método que não retorna um valor, mas pode receber até 16 argumentos de entrada. É útil para representar um método que executa
//uma ação , sem retornar nehum valor

//Func<T, TResult> - Recebe de um até 16 argumentos do tipo T de entrada e retorna um valor do tipo TResult. É útil para representar um método que executa
//uma operação e retorna um resultado

//Predicate 

Console.WriteLine("Informe um número inteiro: ");
int numero = Convert.ToInt32(Console.ReadLine());

Predicate<int> delegatePar = x => x % 2 == 0;

if(delegatePar(numero))
    Console.WriteLine($"O número {numero} é PAR");
else
    Console.WriteLine($"O número {numero} é ÍMPAR");

Console.ReadKey();
