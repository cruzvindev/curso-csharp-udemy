//Eventos são mecanismos que permitem que uma classe ou objeto notifique outras classes ou objetos quando alguma ação ocorre
//A classe que envia (ou aciona) o evento é chamada de Publisher e as classes que recebem (ou manipulam) os eventos são chamadas de Subscribers

//O publisher determina quando um evento é acionado. Os subscribers determinam a ação que é executada em resposta ao evento 
//Um evento pode ter vários assinantes. Um assinante pode manipular vários eventos de vários publicadores
//Eventos que não têm assinantes nunca são invocados 

Console.WriteLine("\nUsando o evento OnCriarPedido");

var pedido = new Pedido();

//inscrever os assinantes no evento
pedido.OnCriarPedido += Email.Enviar;
pedido.OnCriarPedido += SMS.Enviar;

pedido.CriarPedido();

Console.ReadKey();

//criar o delegate para o evento
delegate void PedidoEventHandler();

class Pedido
{
    public event PedidoEventHandler? OnCriarPedido;
    public void CriarPedido()
    {
        Console.WriteLine("\nPedido criado !!!");
        if(OnCriarPedido != null)
        {
            OnCriarPedido();
        }
    }
}

class Email
{
    public static void Enviar()
    {
        Console.WriteLine("\nEnviando um email...");
    }
}

class SMS
{
    public static void Enviar()
    {
        Console.WriteLine("\nEviando um SMS...");
    }
}