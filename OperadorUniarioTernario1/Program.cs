internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Informe o número: \n");
        var n = Convert.ToInt32(Console.ReadLine());

        //O operador "-" nesse caso irá produzir o valor negativo onde ele está sendo executado
        Console.WriteLine($"O negativo de {n} é {-n}");


        //Operador condicional ternário -> Retorna um valor ou outro dependendo do resultado de uma condição

        Console.WriteLine("----------------------------------");
        Console.WriteLine("Informe a temperatura: \n");
        var temp = Convert.ToDouble(Console.ReadLine());

        var resultado = temp > 27 ? "Quente" : "Normal";
        Console.WriteLine($"O tempo está {resultado}");

    }
}