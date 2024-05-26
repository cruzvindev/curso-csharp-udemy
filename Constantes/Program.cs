internal class Program
{
    private static void Main(string[] args)
    {
        //const define variáveis imutáveis 
        const int ANO = 12;

        const int MES = 30, SEMANA = 7, QUINZENA = 15;

        const int MESES_ANO = 12;

        const int DIAS_ANO = 365;

        //calculo da area e perimetro do curculo 

        double raio, perimetro, area;
        const double PI = 3.14;

        Console.WriteLine("Informe o raio do círculo:");
        raio = Convert.ToDouble(Console.ReadLine());

        perimetro = 2 * Math.PI * raio;
        area = Math.PI * Math.Pow(raio, 2);

        Console.WriteLine($"Perímetro = {perimetro}");
        Console.WriteLine($"Área = {area}");

    }
}