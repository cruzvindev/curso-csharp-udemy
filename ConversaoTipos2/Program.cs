internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Conversão de tipos");

        int valorInt = 10;
        double valorDouble = 5.35;
        bool valorBoolean = true;

        //Quando uma conversão de um tipo maior para um tipo menor resultar em perda de dados vai ocorrer uma OverflowExcepition
        Console.WriteLine(Convert.ToString(valorInt));
        Console.WriteLine(Convert.ToDouble(valorInt));
    }
}