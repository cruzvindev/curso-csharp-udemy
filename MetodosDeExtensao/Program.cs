//Métodos de extensão permitem estender a funcionalidade de um tipo existente sem criar um novo tipo derivado, recompilar ou modificar o tipo original
//São um tipo especial de método estático chamado se fosse um método de instância no tipo estendido
//Eles são úteis para estender a funcionalidade de tipos existentes, como classes da biblioteca padrão ou classes definidas por outras bibliotecas de terceiros

//Como criar ?
//1 - Crie uma classe estática para conter o método de extensão.Esta classe deve estar com pelo menos a mesma visibilidade da classe que o contém 
//2 - O parâmetro do método especifica o tipo no qual o método opera. Ele deve ser precedido pelo modificador this
//3 - No código de chamada, adicione uma diretiva using para especificar o namespace que contém a classe do método de extensão
//4 - Chame os métodos como se fossem métodos de instância no tipo

using MetodosDeExtensao;

string texto = "usando métodos de extensão";

string textoInvertido = texto.InverteString();

Console.WriteLine(textoInvertido);

Console.ReadKey();

