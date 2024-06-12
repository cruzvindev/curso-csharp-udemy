//Dictionary representa uma coleção chave/valor e implementa a interface IDictionary(dentre outras) que possui duas coleções em seu interior uma para guardar
//a chave e outra para guardar o valor

//Esta classe está definida no namespace System.Collections.Generic sendo uma classe genérica e pode armazenar qualquer tipo de dados no formato
//chave e valor, onde cada chave deve ser exclusiva na coleção

Dictionary<string, int> dict1 = new Dictionary<string, int>();
Dictionary<string, int> dict2 = new Dictionary<string, int>(5);

dict1.Add("a", 1); //se tentarmos adicionar uma chave já presente uma ArgumentException será lançada
dict1.Add("b", 2);
dict2.Add("c", 3);
dict2.Add("d", 4);
dict2.Add("e", 5);
dict2.Add("f", 6);
dict2.Add("g", 7);
dict2.Add("h", 8);
dict2.Add("i", 9);
dict2.Count();



foreach(var item in dict1)
{
    Console.WriteLine($"{item.Key} {item.Value}");
}