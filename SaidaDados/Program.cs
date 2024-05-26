internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Saída de Dados:");

        int idade = 25;
        string nome = "Vinicius";

        //Escreve na mesma linha 'Vinicius tem 25 anos'
        Console.Write(nome);
        Console.Write(" tem ");
        Console.Write(idade);
        Console.Write(" anos ");

        //Otimizando...
        Console.WriteLine(nome + " tem " + idade + " anos ");

        //usando interpolação

        Console.WriteLine($"{nome} tem {idade} anos");


    }
}