//Serialização JSON
using System.Text.Json;
using System.Text.Json.Serialization;

Aluno aluno1 = new Aluno(101, "Vinicius", "vinicius123@gmail.com", 21);
var caminhoArquivo = @"c:\dados\AlunoSerializado.json";

using (FileStream stream = new FileStream(caminhoArquivo, FileMode.OpenOrCreate, FileAccess.ReadWrite))
{
    JsonSerializer.Serialize(stream, aluno1);
}

Console.WriteLine("Objeto serializado para JSON com sucesso !!!");
Console.ReadKey();

//Desserialização JSON
var caminhoArquivoJSON = @"c:\dados\AlunoSerializado.json";

//Lê todo o conteúdo do arquivo JSON
string jsonContent = File.ReadAllText(caminhoArquivoJSON);

//Desserializa o objeto do arquivo JSON e retorna 
var aluno = JsonSerializer.Deserialize<Aluno>(jsonContent);

Console.WriteLine("Aluno desserializado com sucesso !!!");
Console.ReadKey();



public class Aluno
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }

    [JsonIgnore]//Não serializa esse atributo
    public int Idade;

    public Aluno() { }
    public Aluno(int id, string nome, string email, int idade)
    {
        Id = id;
        Nome = nome;
        Email = email;
        Idade = idade;
    }

}