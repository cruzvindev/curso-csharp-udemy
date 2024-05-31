//Uma Struct é um tipo de dado definido pelo usuário que é composta por outros tipos de dados e funcionalidades relacionadas (semelhante a uma classe)
//Uma Struct pode conter campos, métodos, constantes, contrutores, propriedades, indexadores, operadores e mesmo outros tipos de estruturas

//Uma Struct são tipos de valor, diferente de classes que são tipos de referência. Membros e instãncias de uma struct são criadas na 
// memória Stack e contém seus dados.

public struct Pessoa
{
    public string Nome;
    public int Idade { get; set; }

    public void Exibir()
    {
        Console.WriteLine("Struct");
    }
}