//Na serialização binária, os campos públicos e privados do objeto e o nome da classe, incluindo o assembly que contém a classe, são convertidos em um fluxo 
//de bytes, que é então gravado em um fluxo de dados.

//Quando o objeto for desserializado, um clone exato do objeto original será criado. Vale mencionar que essa abordagem está obsoleta e não é recomendada

//Para serializar um objeto como uma classe, você deve aplicar o atributo Serializable 
//Para não serializar um atributo você deve anotar ele com NonSerialized

using System.Runtime.Serialization.Formatters.Binary;

Aluno aluno1 = new Aluno(101, "Vinicius", "vinicius123@gmail.com", 21);

var caminhoArquivo = @"c:\dados\AlunoSerializado.bin";

using(FileStream stream = new FileStream(caminhoArquivo, FileMode.OpenOrCreate, FileAccess.ReadWrite))
{
#pragma warning disable SYSLIB0011
    var bf = new BinaryFormatter(); //Gera uma exceção no .NET 8
    bf.Serialize(stream, aluno1);
#pragma warning disable SYSLIB0011
    Console.WriteLine("Tecle algo para iniciar a desserialização");
    Console.ReadKey();

    stream.Seek(0, SeekOrigin.Begin);
    var alunoDesserializado = (Aluno)bf.Deserialize(stream);
    Console.WriteLine(alunoDesserializado.Nome);
}

Console.WriteLine("Objeto serializado com sucesso !!!");
Console.ReadKey();


[Serializable]
public class Aluno
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }

    [NonSerialized]
    public int Idade;

    public Aluno(int id, string nome, string email, int idade)
    {
        Id = id;
        Nome = nome;
        Email = email;
        Idade = idade;
    }

}
