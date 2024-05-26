internal class Program
{
    private static void Main(string[] args)
    {

        //Podemos usar o operador var(disponível a partir do C# 3.0) para inferir o tipo da variável a partir do tipo atribuido
        int idade = 25;
        string nome = "Maria";
        decimal salario = 2500.00m;

        Console.WriteLine($"Olá {nome} sua idade é {idade} e seu salário é {salario}");

        /*
        Casos em que o uso de var não é válido

        var salario = null;
        var titulo;
        var salario, imposto, total;
        */
    }
}