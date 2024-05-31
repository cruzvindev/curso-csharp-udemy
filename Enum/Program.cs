//Enum é uma "classe" especial que é definida por um conjunto de constantes nomeadas do tipo numérico
//Por padrão, os valores associados ao membros de uma enum são do tipo int

int categoria1 = (int)Categorias.Automotivo;
var nomeCategoria = (Categorias)2;
Console.WriteLine(categoria1);
Console.WriteLine(nomeCategoria);
public enum Categorias
{
    Moda,//0
    Automotivo,//1
    Artes,//2
    Bebidas,//3
    Livros,//4
    Brinquedos//5
}

//O enum pode ser de qualquer tipo de dados numérico. Basta informar o nome do tipo após o nome do enum

enum DiasDaSemana :byte
{
    Segunda,//0
    Terça,//1
    Quarta,//2
    Quinta,//3
    Sexta,//4
    Sábado,//5
    Domingo//6
}

