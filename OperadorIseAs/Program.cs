//O operador as retorna o objeto quando ele é compatível com o tipo de dado e retorna null se a conversão não for possível ao invés de gerar uma exceção
//O operador is retorna true se o objeto especificado for do mesmo tipo ou false se não for ou se for null

Object carroObj = new Carro();
Carro carro = new Carro();
Automovel automovel = new Automovel();

var y = carroObj as string; //vai retornar null pois a conversão não é possível


if (y != null)
{
    Console.WriteLine("Converteu obj para string");
 } else {
    Console.WriteLine("y é null");
}

if(carro is Automovel)
{
    Console.WriteLine("Converteu");

    var tipo = carro as Automovel;
    tipo?.Ola(); //O operador ? avalia antes se o invocador não é nulo antes de chamar o método, assim evitando uma exception
}
else
{
    Console.WriteLine("Não foi possível realizar esta operação");
}

class Automovel { public void Ola() => Console.WriteLine("Olá"); }
class Carro : Automovel{ public void TipoCarro() => Console.WriteLine("Esportivo"); }