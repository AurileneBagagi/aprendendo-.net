namespace Heranca4;

public class Aluno: Pessoa
{
    public Aluno(string nome): base(nome)
    {
        Nome = nome;
    }

    public void Estudar()=>Console.WriteLine($"{Nome} está Estudando");
}