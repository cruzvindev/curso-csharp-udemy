//Antes do C# 8.0 (2002-2019) uma interface era como uma classe abstrata que continha apenas membros abstratos e qualquer classe ou struct que implementasse uma interface
//devria implementar todos os seus membros

//A partir do C# 8.0 uma interface pode definir implementações padrão para alguns ou todos os seus membros, e uma classe ou struct que implementa uma interface não 
//precisa implementar membros que tenham uma implementação padrão

//A partir do C# 11(2022), os membros da interface que não são campos poder ser static abstract

//Na plataforma .NET recomenda-se utilizar a nomenclatura I + nome da interface, exemplo: IControle



interface IControle
{
    public string Name { get; set; }
    void Desenhar();

    public void Exibir() //Perceba que Demo não precisa implementar esse método pois ele já possui corpo(C# 8.0 +)
    {
        Console.WriteLine("Teste...");
    }
}

public class Demo : IControle
{
    public string Name { get; set; } = string.Empty;

    public void Desenhar()
    {
        Console.WriteLine("Desenhando...");
    }

    public void Pintar()
    {
        Console.WriteLine("Pintando...");
    }
}