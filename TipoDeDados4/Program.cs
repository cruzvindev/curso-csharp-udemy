//tipos de referência - o valor padrão é nulo

internal class Program
{
    private static void Main(string[] args)
    {
        string nome = "Curso C#";
        string titulo = "Curso de C# Essencial";

        //object e dynamic guardam referências de qualquer tipo, entretanto object tende a ser mais seguro em suas verificações
        //dynamic é especialmente útil quando estamos trabalhando usando reflection
        object nota = 10;
        object valor = 8.55m;
        object name = "Maria";
        object ativa = true;
        object letra = 'A';


        dynamic nota2 = 10;
        dynamic valor2 = 8.55m;
        dynamic name2 = "Maria";
        dynamic ativa2 = true;
        dynamic letra2 = 'A';
    }
}