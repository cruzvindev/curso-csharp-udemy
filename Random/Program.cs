//A classe Random do namespace System é usada para gerar números pseudo-aleatórios com base no valor de uma semente (seed)
//O construtor sem parâmetros de Random usa o relógio do sistema para gerar o valor da semente 
//A geração de números aleatórios começa a partir de um valor de semente e se a mesma semente for usada repetidamente, a mesma série de números será gerada

Random random = new Random();
byte[] randBytes = new byte[10];
random.NextBytes(randBytes); 

Console.WriteLine(random.Next());

for (int i = 0; i < 6; i++)
{
    Console.WriteLine(randBytes);
}
