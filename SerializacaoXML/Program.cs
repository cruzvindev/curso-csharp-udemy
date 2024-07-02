using System.Xml.Serialization;

//Serialização XML 
Aluno aluno1 = new Aluno(101, "Vinicius", "vinicius123@gmail.com", 21);
var caminhoArquivo = @"c:\dados\AlunoSerializado.bin";

//Cria um XmlSerializer para o tipo Aluno 
XmlSerializer serializer = new XmlSerializer(typeof(Aluno));

using (StreamWriter writer = new StreamWriter(caminhoArquivo))
{
    serializer.Serialize(writer, aluno1);
}

Console.WriteLine("Objeto serializado para XML com sucesso !!!");
Console.ReadKey();

//Desserialização XML
var caminhoArquivoXml = @"c:\dados\AlunoSerializado.xml";

//Cria um XmlSerializer para o tipo Aluno 
XmlSerializer serializerXml = new XmlSerializer(typeof(Aluno));

using (StreamReader reader = new StreamReader(caminhoArquivoXml))
{
    var aluno = (Aluno)serializer.Deserialize(reader);
    Console.WriteLine("Aluno XML desserializado !!!");
}

Console.ReadKey();

public class Aluno
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public int Idade;

    public Aluno(){}

    public Aluno(int id, string nome, string email, int idade)
    {
        Id = id;
        Nome = nome;
        Email = email;
        Idade = idade;
    }

}
