//Arrays podem ter maids de uma dimensão e o C# suporta arrays com até 32 dimensões 
//Um array com mais de uma dimensão é basicamente um array de array
//Para declarar um array com mais de uma dimensão devemos adicionar vírgulas correspondentes a quantidade de dimensões desejadas entre colchetes

int[,] matriz; //cria uma matriz bidimensional

matriz = new int[2, 2]; //matriz de 2 linhas e 2 colunas

matriz[0, 0] = 0;
matriz[0, 1] = 1;
matriz[1, 0] = 2;
matriz[1,1] = 3;

int[,] b = { { 20, 30 }, { 40, 50 } };//forma simplificada de declarar

//Percorrendo uma matriz

for(int i = 0; i < matriz.GetLength(0); i++) //GetLength retorna o tamanho de uma das dimensões
{
    for(int j = 0; j < matriz.GetLength(1); j++)
    {
        Console.WriteLine($"{matriz[i, j]} ");
    }
}

Console.WriteLine("------------------------------------------------------");

foreach(int x in matriz)
{
    Console.WriteLine($"{x}");
}