/*
 O modificador params em C# permite que um método aceite um número variável de argumentos. 
Ele é usado para especificar um parâmetro que pode receber um array de elementos ou uma lista de argumentos individuais do mesmo tipo.
*/

var res1 = Calcular.Soma(1, 2, 3, 4, 5, 6, 7);
Console.WriteLine(res1);

//semelhante ao varargs do java, o params do C# deve ser o último argumento de um um método quando houver múltiplos parâmetros

public class Calcular
{
    public static int Soma(params int[] numeros)
    {
        int total = 0;
        foreach(var numero in numeros)
        {
            total += numero;
        }
        return total;
    }
}