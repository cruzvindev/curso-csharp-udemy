//Construtor estático é chamado automaticamente antes que a primeira instância seja criada ou que 
//quaisquer membros estáticos sejam referenciados

//uma classe só pode ter um único construtor estático
//o construtor estático só é executado uma única vez
//se não fornecermos um construtor estático para inicializar os campos estáticos eles serão inicializados com os valores padrão


Pessoa p1 = new Pessoa("Vinicius", 20);

Console.WriteLine(p1.Nome + " - " + p1.Idade);
Console.WriteLine("Idade Mínima " + Pessoa.IdadeMinima);


public class Pessoa
{
    public static int IdadeMinima;

    public string Nome { get; set; } = string.Empty;
    public int Idade { get; set; }

    public Pessoa(string nome, int idade)
    {
        Console.WriteLine("\nExecutando construtor parametrizado");
        Nome = nome;
        Idade = idade;
    }

    public Pessoa() { }

    //construtor estático
    static Pessoa()
    {
        Console.WriteLine("\nExecutando o construtor estático");
        Console.WriteLine("Inicializando o campo IdadeMinima");
        IdadeMinima = 18;
    }
}