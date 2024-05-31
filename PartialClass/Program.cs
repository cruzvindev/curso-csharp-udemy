using PartialClass;

MinhaPartialClass minhaPartialClass = new MinhaPartialClass();
var idade = minhaPartialClass.CalculaIdade(new DateTime(2003, 6, 26)); //perceba que estamos usando um método que não está definido em MinhaPartialClass
Console.WriteLine($"{(idade.TotalDays / 365)} anos");