//No C# podemos definir algumas constraints no generics, as principais usadas são: struct, class e new()
//struct - T deve ser um tipo de valor
//class - T deve ser ser um tipo de referência
//new() - T deve ter um construtor público sem parâmetros

//Podemos ter mais de uma restrição, exemplo:
//public class ClasseGeneric<T1, T2> where T1: struct where T2: class{}

Teste<int, int> teste = new Teste<int, int>();
Teste<float, float> teste2 = new Teste<float, float>();

int i1 = 10;
int i2 = 10;

float f1 = 10;
float f2 = 10;

string s1 = "10";
string s2 = "10";

teste.Comparar(i1, i2);
teste2.Comparar(f1, f2);


public class Teste<T1, T2> where T1: struct where T2 : struct
{
    public void Comparar(T1 p1, T2 p2)
    {
        Console.WriteLine($"Os tipos: {p1.GetType()} e {p2.GetType()}");
        var resultado = p1.Equals(p2);
        Console.WriteLine($" {p1} e {p2} são iguais ? {resultado}\n");
    }
}