//O C# possui delegates pré-definidos que podemos usar para passar referências a métodos como argumentos para outros métodos como argumentos
//para outros métodos 

//Predicate<T> - Representa um método que recebe um único argumento do tipo T e retorna um valor booleano. Pode ser usado para testar se um objeto
//satisfaz uma condição específica

//Action<T> - Representa um método que não retorna um valor, mas pode receber até 16 argumentos de entrada. É útil para representar um método que executa
//uma ação , sem retornar nehum valor

//Func<T, TResult> - Recebe de um até 16 argumentos do tipo T de entrada e retorna um valor do tipo TResult. É útil para representar um método que executa
//uma operação e retorna um resultado

//Action

Console.WriteLine("Informe um número inteiro: ");
int numero = Convert.ToInt32(Console.ReadLine());

Action<int> dobra = x => Console.WriteLine(x * 2);
dobra(numero);

Console.ReadKey();