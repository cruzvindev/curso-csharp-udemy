//Uma função anônima é uma função que não possui nome e que pode ser definida usando a palavra-chave delegate e pode ser atribuída a uma variável do 
//tipo delegate 

//Uma função anônima é uma declaração inline ou expressão que pode ser usada sempre que um tipo de delegate for esperado

//Podemos usá-las para inicializar um delegate nomeado ou passar um método anônimo em vez de um tipo delegate nomeado como um parâmetro de método

//Existem dois tipos de funções anônimas: métodos anônimos e expressões lambda

public class Program
{
    private static void Main(string[] args)
    {
        Imprimir imprimir = delegate (int valor)
        {
            Console.WriteLine($"Método anônimo. Valor: {valor}");
        };

        imprimir(100);


        List<string> nomes = new List<string>();
        nomes.Add("Maria");
        nomes.Add("Miriam");
        nomes.Add("Vinicius");
        nomes.Add("João");

        //string resultado = nomes.Find(VerificaNomeNaLista);

        string resultado = nomes.Find(delegate (string nome)
        { 
            return nomes.Equals("Vinicius"); 
        });

        Console.WriteLine(resultado);
        Console.ReadKey();

       
    }

    static bool VerificaNomeNaLista(string nome)
    {
        Console.WriteLine($"Consultando nome na lista: {nome}");
        return nome.Equals("Vinicius");
    }
}

public delegate void Imprimir(int valor);
