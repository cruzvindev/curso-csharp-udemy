//No C# temos 2 tipos de delegate: 
//1 - SingleCast Delegate => delegate que referencia e invoca um único método
//2 - MulticastDelegate => delegate que referencia e invoca mais de um método

MeuDelegate delegateMulticast = new MeuDelegate(Metodo1);

//Multicast delegate
delegateMulticast += Metodo2;
delegateMulticast += Metodo3;

//removendo um método
delegateMulticast -= Metodo3;

delegateMulticast("Olá, multicast delegate!");

static void Metodo1(string mensagem)
{
    Console.WriteLine("Método 1: " + mensagem);
}

static void Metodo2(string mensagem)
{
    Console.WriteLine("Método 2: " + mensagem);
}

static void Metodo3(string mensagem)
{
    Console.WriteLine("Método 3: " + mensagem);
}

public delegate void MeuDelegate(string mensagem);  