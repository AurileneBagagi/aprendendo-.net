int total = 3;
Pessoa[] pessoas = new Pessoa[total];

for (int i = 0; i < total; i++)
{
    if (i == 0)
    {
        Console.WriteLine("Informe o nome do Professor");
        pessoas[i] = new Professor(Console.ReadLine());
    }
    else
    {
        Console.WriteLine("Informe o nome do Aluno");
        pessoas[i] = new Aluno(Console.ReadLine());
    }
}

for (int i = 0; i < total; i++)
{
    if (i == 0)
    {
        Console.Write("Professor... ");
        ((Professor)pessoas[i]).Explicar();
    }
    else
    {
        Console.Write("Aluno... ");
        ((Aluno)pessoas[i]).Estudar();
    }
}
Console.ReadKey();
public class Pessoa
{
    protected string Nome { get; set; }
    public Pessoa(string nome)
    {
        Nome = nome;
    }
    public override string ToString()
    {
        return "Olá! Meu nome é  " + Nome;
    }
}
public class Professor : Pessoa
{
    public Professor(string nome) : base(nome)
    {
        Nome = nome;
    }

    public void Explicar()
    {
        Console.WriteLine($"{Nome} Explicando...");
    }
}

public class Aluno : Pessoa
{
    public Aluno(string nome) : base(nome)
    {
        Nome = nome;
    }
    public void Estudar()
    {
        Console.WriteLine($"{Nome} Estudando...");
    }
}
