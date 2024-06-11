//Um relacionamento de agregação é um tipo de composição onde objetos de uma classe podem conter um ou mais objetos de outra classe

Professor prof1 = new Professor("João", "Física");
Professor prof2 = new Professor("Maria", "Filosofia");
Professor prof3 = new Professor("Humberto", "Matemática");
Professor prof4 = new Professor("Luan", "História");

Departamento dep1 = new Departamento("Exatas");
dep1.IncluirProfessor(prof1);
dep1.IncluirProfessor(prof3);

Departamento dep2 = new Departamento("Humanas");
dep2.IncluirProfessor(prof2);
dep2.IncluirProfessor(prof4);

dep1.ListaProfessores();
dep2.ListaProfessores();

class Departamento
{
    public string Nome { get; set; }
    public List<Professor>? professores { get; set; }

    public Departamento(string? nome)
    {
        Nome = nome;
        professores = new List<Professor>();
    }

    public void IncluirProfessor(Professor professor)
    {
        professores?.Add(professor); //Elvis operator =>  ?
    }

    public void ListaProfessores()
    {
        Console.WriteLine($"\nDepartamento de : {Nome}\n");

        foreach(var prof in professores)
        {
            Console.WriteLine(prof.Nome + " -> " + prof.Disciplina);
        }
    }
}


class Professor
{
    public string? Nome { get; set; }
    public string? Disciplina {  get; set; }

    public Professor(string? nome, string? disciplina)
    {
        Nome = nome;
        Disciplina = disciplina;
    }
}