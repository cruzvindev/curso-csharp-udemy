
Aluno aluno = new Aluno("Vinicius", 20, "Masculino", "Sim");
Console.WriteLine(aluno.ToString());


public class Aluno
{
    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;

    public Aluno(string nome) => Nome = nome;

    public Aluno(string? nome, int idade, string? sexo, string? aprovado) : this(nome) //chamando outro construtor
    {
        this.Nome = nome;
        this.Idade = idade;
        this.Sexo = sexo;
        this.Aprovado = aprovado;
    }

    public override string ToString()
    {
        return $"Nome: {Nome}\n Idade: {Idade}\n Sexo: {Sexo}\n Aprovado: {Aprovado}";
    }
}