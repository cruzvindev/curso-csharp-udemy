//O modificador abstract quando usado em uma Classe indica que a mesma destina-se a ser apenas uma classe base de outras classes, não podendo ser instanciada
//Membros marcados com abstractdevem ser implementados por classes não abstratas que derivam de uma classe abstrata
//Métodos abstratos são implicitamente um método virtual 
//Classes derivadas de uma classe abstrata são obrigadas a implementar os seus métodos abstratos 
//Não podemos usar virtual e static em métodos abstratos 


Quadrado q = new Quadrado();
Console.WriteLine(q.Descricao());

Console.WriteLine("\nInforme a cor da figura");
q.Cor = Console.ReadLine();

Console.WriteLine("\nInforme o valor do lado do quadrado");
q.Lado = Convert.ToInt32(Console.ReadLine());   

q.CalcularArea();
q.CalcularPerimetro();

Console.WriteLine($"\nÁrea do quadrado: {q.Area} m2");
Console.WriteLine($"\nPerímetro do quadrado: {q.Perimetro} m");
Console.WriteLine($"\n O quadrado tem a cor: {q.Cor}");


public abstract class Forma
{
    public string Cor { get; set; }
    public double Area {  get; set; }
    public double Perimetro { get; set; }

    public abstract void CalcularArea();
    public abstract void CalcularPerimetro();

    public string Descricao()
    {
        return "Sou a classe abstrata forma";
    }
}


public class Quadrado : Forma
{

    public double Lado { get; set; }
    public override void CalcularArea()
    {
        this.Area = Math.Pow(this.Lado, 2);
    }

    public override void CalcularPerimetro()
    {
        this.Perimetro = 4 * Lado;
    }
}