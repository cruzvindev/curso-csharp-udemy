internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nullable Types !!!");

        int? i = null;
        double? d = null;
        bool? b = null;

        //Para simplificarmos essa declaração podemos fazer uso do operador "?"

        int? i2 = null;
        double? d2 = null;
        bool? b2 = null;

        Console.WriteLine(i);
        Console.WriteLine(d);
        Console.WriteLine(b);

        // int? é DIFERENTE de int => um pode ter valores nulos e o outro não

        /* Isso gera uma exceção
        int? exemplo = null;
        int exemplo2 = exemplo;
        Console.WriteLine(exemplo2);
        */

        //Para contornar isso podemos usar o operador de coalescência nula "??" para atribuirmos um valor a um tipo não nullable type

        int? aa = null;
        int bb = aa ?? 0; // se aa não for nulo o valor dele é atribuido a bb, se não o valor 0 é atribuido
        Console.WriteLine(bb);

        Console.WriteLine("-----------------------------------------");

        //Nullable Types possuem duas propriedades read only: HasValue e Value 
        //HasValue => true se tiver um valor e false se não tiver(null)
        //Value => Exibe o valor atribuído

        int? f = 100;
        if (f.HasValue)
        {
            Console.WriteLine($"f = {f.Value}");
        }
        else
        {
            Console.WriteLine("f não possui um valor");
        }
    }
}