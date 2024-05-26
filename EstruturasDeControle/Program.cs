internal class Program
{
    private static void Main(string[] args)
    {
        //Else if 

        Console.WriteLine("Informe a nota do aluno \t");
        var nota = Convert.ToDouble(Console.ReadLine());

        if(nota < 5)
        {
            Console.WriteLine("\nALUNO REPROVADO");
        }

        else if (nota >= 5 && nota < 6)
        {
            Console.WriteLine("\nALUNO EM RECUPERAÇÃO");
        }
        else if(nota >= 6 && nota <= 9)
        {
            Console.WriteLine("\nALUNO APROVADO");
        }
        else if (nota > 9)
        {
            Console.WriteLine("\nALUNO APROVADO COM DISTINÇÃO");
        }

        Console.WriteLine("FIM DO PROCESSAMENTO...\n");


    }
}