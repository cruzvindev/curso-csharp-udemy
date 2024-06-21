//O C# possui dois delegates pré-definidos para manipular eventos que possuem e que não possuem dados

//1 - EventHandler -> Representa um método que vai manipular um evento que não possui dados

//public delegate void EventHandler(object? sender, EventArgs e);
//  - object? sender : contém uma referência ao objeto que gerou o evento (fonte do evento)
//  - EventArgs : um objeto que não contém nenhum dado de um evento 

//2 - EventHandler<TEventArgs> -> Representa um método que vai manipular um evento que possui dados 
//public delegate void EventHandler<TEventArgs>(object? sender, TEventArgs e);
//  - TEventArgs : o tipo dos dados do evento gerado pelo evento
// - object? sender : contém uma referência ao objeto que gerou (fonte do evento) 
// - TEventArgs : um objeto que contém os dados de um evento 

//Para passar os dados no segundo parâmetro do manipulador de eventos do Publicador para os assinantes , temos que definir uma classe que herda da classe
//EventArgs e armazenar os dados que desejamos passar na classe

using System;

Console.WriteLine("\nUsando o evento OnCriarPedido");

var pedido = new Pedido();

//inscrever os assinantes no evento
pedido.OnCriarPedido += Email.Enviar;
pedido.OnCriarPedido += SMS.Enviar;

pedido.CriarPedido("vinicin@email.com", "(83) 98888-9999");

Console.ReadKey();

//criar o delegate para o evento
delegate void PedidoEventHandler();

class PedidoEventArgs : EventArgs
{
    public string? Email { get; set; }  
    public string? Telefone { get; set; }
}

class Pedido
{
    //criar o evento associado ao delegate 
    public event EventHandler<PedidoEventArgs> OnCriarPedido;
    public void CriarPedido(string email, string fone)
    {
        Console.WriteLine("\nPedido criado !!!");
        if (OnCriarPedido != null)
        {
            OnCriarPedido(this, new PedidoEventArgs { Email = email, Telefone = fone});
        }
    }
}

class Email
{
    //os métodos assinantes devem possuir a mesma assinatura do delegate 
    public static void Enviar(object? sender, PedidoEventArgs e)
    {
        Console.WriteLine($"\nEnviando um email para : { e.Email}");
    }
}

class SMS
{
    public static void Enviar(object? sender, PedidoEventArgs e)
    {
        Console.WriteLine($"\nEviando um SMS para {e.Telefone}");
    }
}