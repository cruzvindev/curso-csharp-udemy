internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\nInforme seu nome:");

        string nome = Console.ReadLine();

        Console.WriteLine("\nO seu nome é " + nome);

        Console.WriteLine("\nInforme sua idade:");

        int idade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n A sua idade é " + idade);

        Console.ReadKey(); 

    }
}