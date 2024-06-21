//Em C#, expressões lambda são uma forma concisa de definir funções anônimas. Elas são usadas para criar métodos inline que podem ser
//passados como argumentos para métodos ou atribuídos a variáveis de delegado. As expressões lambda são uma parte fundamental do LINQ
//e são amplamente usadas em programação funcional e para manipulação de coleções.


List<string> nomes = new List<string>();
nomes.Add("Maria");
nomes.Add("Miriam");
nomes.Add("Vinicius");
nomes.Add("João");

/*
string resultado = nomes.Find(delegate (string nome)
{
    return nomes.Equals("Vinicius");
});
*/

//Usando lambda
string resultado = nomes.Find(nome => nome.Equals("Vinicius"));

Console.WriteLine(resultado);
Console.ReadKey();