int x = 20;

Console.WriteLine("\nValor do argumento x antes de passar por valor " + x);

Calculo calc = new(); //Target-Typed new expressions - C# 9.0 e superior - o compilador consegue inferir o tipo do objeto a partir do contexto
calc.Dobrar(ref x); //passando a cópia da referência de x

Console.WriteLine("-----------------------------------------");
Console.WriteLine("Informe o raio do círculo");
double raio = Convert.ToDouble(Console.ReadLine());

Circulo circulo = new();

double perimetro = circulo.CalculaAreaPerimetro(raio, out double area);

Console.WriteLine("Perímetro da circunferência: " + perimetro);
Console.WriteLine("Área da circunferência: " + area);

public class Calculo
{
    public void Dobrar(ref int y)
    {
        y *= 2;
        Console.WriteLine("\nValor do parâmetro y no método Dobrar " + y);
    }
}


//out
//A variável não precisa ser inicializada antes de ser passada para o método, mas deve ser inicializada dentro do método.
public class Circulo
{

    public double CalculaAreaPerimetro(double raio, out double area)
    {
        area = Math.PI * Math.Pow(raio, 2);
        double perimetro = 2 * Math.PI * raio;
        return perimetro;
    }
}