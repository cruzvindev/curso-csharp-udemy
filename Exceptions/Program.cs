//No C# exceção pode ser definida como um objeto que herda da classe System.Exception que é criado ou lançado quando ocorre uma condição de erro

try
{
    Console.WriteLine("\nInforme o dividendo");
    int dividendo = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\nInforme o divisor");
    int divisor = Convert.ToInt32(Console.ReadLine());

    int resultado = (dividendo / divisor);
    Console.WriteLine($"\n{dividendo} / {divisor} = {resultado}\n");
}
catch (Exception e)
{
    Console.WriteLine($"\n{e.GetType()} informa : {e.Message}");
    Console.WriteLine($"\n {e.Message}");
    Console.WriteLine($"\n {e.StackTrace}");
}

//O recurso exception filters foi introduzido no C# 6.0 e permite executar blocos try catch com base em uma condição específica quando ocorre uma exceção

Console.WriteLine("--------------------------------------------------------");

try
{
    Console.WriteLine("\nInforme o dividendo");
    int dividendo = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\nInforme o divisor");
    int divisor = Convert.ToInt32(Console.ReadLine());

    int resultado = (dividendo / divisor);
    Console.WriteLine($"\n{dividendo} / {divisor} = {resultado}\n");
}
catch (DivideByZeroException ex) when (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
{
    Console.WriteLine("\nHoje é sexta-feira e não capturamos estas exceções hoje ! sextouuu!");
}
catch(Exception ex) when (ex.Message.Contains("format"))
{
    Console.WriteLine("filtro de exceção com format");
    Console.WriteLine(ex.StackTrace);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

//Criando exception personalizada 

public class MinhaExcecaoException : Exception
{
    public MinhaExcecaoException() { }

    public MinhaExcecaoException(string message) : base(message) { }

    public MinhaExcecaoException(string message, Exception inner) : base(message, inner) { }

    //Reescrever os métodos ToString e HelpLink
}