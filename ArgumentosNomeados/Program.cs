Email email = new();

email.Enviar("teste@email.com", "Reunião de orçamento", "Urgente");

//argumentos nomeados
email.Enviar(titulo: "Urgente", destino: "teste@email.com", assunto: "Reunião Orçamento");








public class Email
{

    public void Enviar(string destino, string titulo, string assunto)
    {
        Console.WriteLine($"\nPara {destino} - {titulo} \n Assunto: {assunto}");
    }
}