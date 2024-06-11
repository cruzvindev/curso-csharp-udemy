//A operação de Upcasting converte um objeto de um tipo especializado(classe derivada ou filha) para um tipo mais geral(classe base ou pai)
//Podemos entender o upcasting como a atribuição de um objeto de uma classe filha para uma referência de uma classe base
//Essa operação é implícita, e, não é preciso ser feita de forma explícita, sendo sempre possível de ser realizada

//A operação de Downcasting converte um objeto de um tipo geral para um tipo mais especializado
//Podemos entender o downcasting como a atribuição de um objeto da classe base para um objeto da classe derivada
//Deve ser feita explícitamente pois pode falhar e lançar uma exceção, ou seja, nem sempre pode ser realizada

Forma circulo = new Circulo(10, 20); //upcasting - Circulo deriva de Forma
circulo.Desenhar(); //Não consigo invocar PintarCirculo a partir dessa referência, pois ela tem uma visão limitada

Forma forma = circulo; //outra forma de fazer upcasting

Console.WriteLine(forma == circulo);

Circulo c = (Circulo)forma; //downcasting - nesse caso é possível pois forma armazena uma referência para um círculo


class Forma
{
    protected int xpos, ypos;

    public Forma() { }

    public Forma(int x, int y)
    { 
        xpos = x;
        ypos = y;
    }

    public virtual void Desenhar() => Console.WriteLine($"Desenhar - Forma na posição: {xpos}, {ypos}");
}


class Circulo : Forma
{
    public Circulo() { }

    public Circulo(int x, int y) : base(x, y) { }

    public override void Desenhar() => Console.WriteLine($"Desenhar - Forma na posição: {xpos}, {ypos}");

    public void PintarCirculo()
    {
        Console.WriteLine("Pintar o Circulo");
    }
}