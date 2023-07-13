namespace _16Agregacao;

internal class Departamento
{
    public string? Nome { get; set; }
    private List<Professor>? professores { get; set; } //sinaliza que é uma lista de professores

    public Departamento(string? nome)
    {
        Nome = nome;
        professores = new List<Professor>();//cria a lista
    }
    public void IncluirProfessor(Professor professor)
    {
        professores?.Add(professor); //recebe o objeto e adiocona na lista 
    }
    public void ListaProfessores()
    {
        Console.WriteLine($"\nDepartamento de : {Nome}\n");

        foreach (var prof in professores)
            Console.WriteLine(prof.Nome + " -> " + prof.Disciplina);
    }

}
