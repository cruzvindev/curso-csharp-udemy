internal class Program
{
    private static void Main(string[] args)
    {

        string? nome = "Vinicius";

        //Se nome não for nulo o método é executado, se nome for nulo ele não é executado
        Console.WriteLine(nome?.ToUpper());

    }
}