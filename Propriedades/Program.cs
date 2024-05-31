//Uma propriedade é um membro da classe, que fornece um mecanismo para ler, gravar ou calcular o valor de um campo privado
//As propriedades podem ser usadas como se fossem membros de dados públicos, mas possuem métodos especiais chamados acessadores

//As propriedades permitem que uma classe exponha uma maneira pública de obter e definir valores, enquanto oculta o código de implementação ou verificação

//Uma propriedade é uma combinação de um campo privado e de dois acessadores: o get e o set

public class Pessoa
{
    private string nome; //campo
    public String Nome //propriedade
    {
        get { return nome; }
        set { nome = value; }
    }

    //Nova forma (comumente usada) de declarar uma propriedade. O compilador gera o campo privado

    public string Name { get; set; }

    //As propriedades leitura e gravação têm um acessador get e um set(padrão)
    //As propriedades somente leitura têm um acessador get, mas nenhum acessador set
    //As propriedades somente gravação têm um acessador set, mas não têm um acessador get
}