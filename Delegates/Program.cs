//Um delegate é um tipo de referência que representa referências a métodos com uma lista de parâmetros e um tipo de retorno específicos
//Ao instanciar um delegate, podemos associar a sua instância a qualquer método com uma assinatura compatível e tipo de retorno,e, podemos invocar o método por meio da instância delegada


using Delegates;

var resultado = Calculadora.Somar(10, 40);

Console.WriteLine(resultado);

//Formas de associar um delegate a um método
DelegateCalculadora calc = new DelegateCalculadora(Calculadora.Somar);
var resultado1 = calc.Invoke(20, 30);
Console.WriteLine($"Soma = {resultado1}");

DelegateCalculadora calc2 = Calculadora.Somar;
var resultado2 = calc2.Invoke(20, 30);
Console.WriteLine($"Soma = {resultado1}");

DelegateCalculadora calc3 = (float x, float y) => Calculadora.Somar(x, y);
var resultado3 = calc3.Invoke(20, 30);
Console.WriteLine($"Soma = {resultado1}");

Console.ReadKey();

public delegate float DelegateCalculadora(float x , float y);