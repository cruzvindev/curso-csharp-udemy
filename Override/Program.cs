//Se quisermos que um membro da subclasse substitua um membro com o mesmo nome na classe base deve fazer o seguinte
//1 - Usar o modificador virtual na declaração do membro da classe base para indicar que ele pode ser sobrescrito
//2 -  Usar o modificador override na declaração do membro na classe derivado

Aluno aluno = new();
aluno.Nome = "Vinicius";
aluno.Curso = "Ciência da Computação";

Console.WriteLine(aluno.Saudacao());

class Pessoa
{
    public string? Nome { get; set; }
    public virtual string Saudacao() => $"Oi, eu sou o(a) {Nome}";
}

class Aluno : Pessoa
{
    public string? Curso { get; set; }
    public override string Saudacao() => $"Oi, eu sou o(a) {Nome} e curso {Curso}";
}