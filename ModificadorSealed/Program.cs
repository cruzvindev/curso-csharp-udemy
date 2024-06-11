//Quando aplicamos o modificador sealed impede que outras classes herdem dela
//Quando aplicado a métodos ele vai impedir que as classes que herdem a classe base possam sobrescreve-lo

sealed class Pessoa
{
    public string? Nome { get; set; }
}


class Aluno : Pessoa //Perceba que o compilador emite um alerta de erro
{
    public string Curso { get; set; }
}