using Generic9;
Console.WriteLine("###### Questão 9 do exercicio de Generics ######");
List<Aluno> alunos = new List<Aluno>();

alunos.Add(new Aluno("Amanda", 15, 'F'));
alunos.Add(new Aluno("João", 16, 'M'));
alunos.Add(new Aluno("Joel", 14, 'M'));
alunos.Add(new Aluno("Mar", 15, 'F'));
alunos.Add(new Aluno("Matheus", 15, 'M'));

Exibindo(alunos);

static void Exibindo(List<Aluno> alunos)
{
    Console.WriteLine("----- Alunos -----");
    Console.WriteLine("Nome\tIdade\tSexo");
    foreach (var item in alunos)
    {
        Console.WriteLine($"{item.Nome}\t{item.Idade}\t{item.Sexo}");
    }
}