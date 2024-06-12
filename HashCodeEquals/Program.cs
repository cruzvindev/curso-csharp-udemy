//O método GetHashCode retorna um valor inteiro (código hash) com a base nas informações do objeto(estado do objeto), enquanto Equals compara o objeto com outro objeto
//e retorna um booleano indicando se eles são iguais

//Nos tipos definidos pelo usuário é necessário sobrescrever os métodos GetHashCode e Equals

var pessoa1 = new Pessoa(123456, "Vinicius");
var pessoa2 = new Pessoa(123456, "Vinicius");
var pessoa3 = new Pessoa(987654, "Vinicius");

Console.WriteLine("pessoa1 -> Cpf = 123456 Nome = Vinicius");
Console.WriteLine("pessoa2 -> Cpf = 123456 Nome = Vinicius");
Console.WriteLine("pessoa3 -> Cpf = 987654 Nome = Erica");

Console.WriteLine("\nComparando objetos Pessoa - GetHashCode");
Console.WriteLine("pessoa1 = " + pessoa1.GetHashCode());
Console.WriteLine("pessoa2 = " + pessoa2.GetHashCode());
Console.WriteLine("pessoa3 = " + pessoa3.GetHashCode());

Console.WriteLine("\nComparando objetos Pessoa - Equals");
Console.WriteLine("pessoa1.Equals(pessoa2) = " + pessoa1.Equals(pessoa2));
Console.WriteLine("pessoa2.Equals(pessoa3) = " + pessoa2.Equals(pessoa3));



public class Pessoa
{
    public int CPF { get; set; }
    public string Nome {  get; set; }

    public Pessoa (int cpf , string nome)
    {
        CPF = cpf; 
        Nome = nome;   
    }

    public override bool Equals(object? obj)
    {
        if (obj == null) return false;
        if(obj is not  Pessoa) return false; 

        var other = (Pessoa)obj;
        return CPF.Equals(other.CPF);
    }

    public override int GetHashCode()
    {
        return CPF.GetHashCode();
    }
}