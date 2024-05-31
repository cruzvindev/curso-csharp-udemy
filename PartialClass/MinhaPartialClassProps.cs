//A partir da versão 2.0 a plataforma .NET introduziu o recurso chamado partial class que permite que uma classe venha a ser implementada em múltiplos arquivos
//físicos com extensão .cs
//Dessa forma é possível dividir a definição de uma classe, struct, interface ou método em dois ou mais arquivos de origem
//Cada arquivo de origem contém as definições de membros, tipos ou métodos e todas as parte são combinadas quando o aplicativo for compilado
namespace PartialClass;
public partial class MinhaPartialClassProps
{
    public DateTime DataNascimento { get; set; }    
    public string? Nome {  get; set; }  
}