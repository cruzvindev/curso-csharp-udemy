//Através do polimorfismo podemos invocar métodos da classe derivada através da classe base em tempo de execução
//Podemos permitir que classes forneçam diferentes implementações de métodos que são chamados com o mesmo nome;

var figuras = new List<Figura>
{
    new Triangulo(),
    new Circulo()
};

foreach(var figura in figuras)
{
    figura.Desenhar();
}

public class Figura
{
    public virtual void Desenhar()
    {
        Console.WriteLine("Executando Desenhar na classe base...");
    }
}

public class Circulo : Figura
{
    public override void Desenhar()
    {
        Console.WriteLine("Desenhando um circulo...");
    }
}

public class Triangulo : Figura
{
    public override void Desenhar()
    {
        Console.WriteLine("Desenhando um triângulo...");
        base.Desenhar();
    }
}