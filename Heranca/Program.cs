using Heranca;

Console.WriteLine("HERANÇA");

Funcionario funcionario = new();
funcionario.Nome = "Vinicius";
funcionario.Email = "vinicius123@email.com";
funcionario.Empresa = "Google";
funcionario.Salario = 9000;

Console.WriteLine("-------------------------------");
Console.WriteLine(funcionario.Empresa);
Console.WriteLine(funcionario.Salario);
funcionario.Identificar();
Console.WriteLine("-------------------------------");

Aluno aluno = new();
aluno.Nome = "José";
aluno.Email = "jose@email.com";
aluno.Curso = "Engenharia de Computação";
aluno.Nota = 9;

Console.WriteLine(aluno.Curso);
Console.WriteLine(aluno.Nota);
Console.WriteLine("-------------------------------");