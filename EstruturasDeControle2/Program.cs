internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Valor da compra R$600,00\n");
        Console.WriteLine("Informe o número de parcelas (1 a 3)\t");
        var numeroParcelas = Convert.ToInt32(Console.ReadLine());


        switch (numeroParcelas)
        {
            case 1:
                Console.WriteLine($"\nPrestação R$ {600 / numeroParcelas}");
                break;
            case 2:
                Console.WriteLine($"\nPrestação R$ {600 / numeroParcelas}");
                break;
            case 3:
                Console.WriteLine($"\nPrestação R$ {600 / numeroParcelas}");
                break;
        }

        Console.WriteLine("\n-----------------------------");

        Console.WriteLine("Informe um mês");
        var mes = Console.ReadLine().ToLower();

        switch (mes)
        {
            case "janeiro":
            case "março":
            case "maio":
            case "julho":
            case "agosto":
            case "outubro":
            case "dezembro":
                Console.WriteLine("Este mês tem 31 dias");
                break;
            case "fevereiro":
                Console.WriteLine("Este mês tem 28 ou 29 dias");
                break;
            default:
                Console.WriteLine("Este mês tem 30 dias");
                break;
        }

    }
}