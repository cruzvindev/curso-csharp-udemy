//A partir do C# temos a funcionalidade de streams assíncronos. Com eles podemos criar IEnumerables que geram dados de forma assíncrona

//Para que isso seja possível devemos seguir algumas regaras:
//1 - O método deve ser assíncrono (async/await)
//2 - O tipo de retorno do método deve ser um IAsyncEnumerable<T>
//3 - O corpo do método deve conter pelo menos uma chamada a yield return(retorna elemento sucetíveis no stream assíncrono)


await foreach (var mes in GeraMeses())
{
    Console.WriteLine(mes);
}

Console.ReadKey();

static async IAsyncEnumerable<string> GeraMeses()
{
    yield return "Janeiro";
    yield return "Fevereiro";
    yield return "Março";
    yield return "Abril";
    await Task.Delay(2000);
    yield return "Maio";
    yield return "Junho";
}


