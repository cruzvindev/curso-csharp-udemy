Email email = new();

email.Enviar("teste@email.com", "Reunião de orçamento", "Urgente");

//argumentos nomeados
email.Enviar(destino: "teste@email.com", assunto: "Reunião Orçamento");








public class Email
{
    //Os parâmetros opcionais sempre vão depois dos obrigatórios
    public void Enviar(string assunto, string destino="Destino padrão", string titulo="Título padrão")
    {
        Console.WriteLine($"\nPara {destino} - {titulo} \n Assunto: {assunto}");
    }
}