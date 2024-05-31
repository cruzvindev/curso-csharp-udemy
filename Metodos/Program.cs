/*
 No C#, alguns tipos possuem aliases para facilitar a escrita e melhorar a legibilidade do código. Por exemplo:

- string é um alias para System.String
- int é um alias para System.Int32
- bool é um alias para System.Boolean

*/
MinhaClasse minhaClasse = new MinhaClasse();

minhaClasse.Saudacao();




public class MinhaClasse
{
    public void Saudacao()
    {
        Console.WriteLine("Bem-vindo");
        ExibirDataAtual();
    }

    public void ExibirDataAtual() => Console.WriteLine(DateTime.Now.ToShortDateString());
}