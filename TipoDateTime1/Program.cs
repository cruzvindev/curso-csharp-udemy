internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("## Struct DateTime ##\n");
        DateTime dataAtual = DateTime.Now;

        Console.WriteLine(dataAtual);

        //criar uma data específica 
        DateTime dataHoje = new DateTime(2024, 05, 22);
        Console.WriteLine(dataHoje);

        //definir as horas 
        DateTime dataHoraHoje = new DateTime(2024, 05, 22, 21, 05, 30);
        Console.WriteLine(dataHoraHoje);

        //extrair informações 
        Console.WriteLine(dataAtual.Year);
        Console.WriteLine(dataAtual.Month);
        Console.WriteLine(dataAtual.Day);
        Console.WriteLine(dataAtual.Hour);
        Console.WriteLine(dataAtual.Minute);
        Console.WriteLine(dataAtual.Second);
        Console.WriteLine(dataAtual.Millisecond);

        Console.WriteLine("--------------------------------------------------");

        //adicionando valores
        Console.WriteLine(dataAtual.AddDays(30));
        Console.WriteLine(dataAtual.AddMonths(1));
        Console.WriteLine(dataAtual.AddDays(30));
        Console.WriteLine(dataAtual.AddHours(2));
        Console.WriteLine(dataAtual.AddYears(5));

        Console.WriteLine("--------------------------------------------------");

        Console.WriteLine(dataAtual.DayOfWeek);
        Console.WriteLine(dataAtual.DayOfYear);

    }
}