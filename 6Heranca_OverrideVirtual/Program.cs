Aluno aluno = new();
aluno.Nome = "Maria";
aluno.Curso = "Quimica";
Console.WriteLine(aluno.Saudacao());

Console.ReadKey();

class Pessoa
{
    public string? Nome { get; set; }

    public virtual string Saudacao() => $"Oi, Eu sou o(a) {Nome}"; //metodo com uso de lambda
}

class Aluno : Pessoa
{
    public string? Curso { get; set; }

    public override string Saudacao()
        => $"Oi, Eu sou o(a) {Nome} do curso de : {Curso}.";
        //sem o new o override ocorre de forma intencional
}