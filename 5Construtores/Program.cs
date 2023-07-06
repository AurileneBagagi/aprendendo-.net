Console.WriteLine("## Construtores ##\n");

//so aceita os valores assim se houver um construtor
Aluno aluno = new Aluno("Maria",22,"feminino","S");

//verificando os valores padrões ou posto ao intanciar um objeto.
Console.WriteLine(aluno.Nome == null ? "null" : aluno.Nome);
Console.WriteLine(aluno.Idade == 0 ? "zero" : aluno.Idade);
Console.WriteLine(aluno.Sexo == null ? "null" : aluno.Sexo);
Console.WriteLine(aluno.Aprovado == null ? "null" : aluno.Aprovado);

Console.ReadKey();

public class Aluno
{
    //criando um construtor para apenas um parametro, para criar um construtor digitar ctor
    public Aluno(string nome)=> Nome = nome;// corpo de expressão/expression body
    //a palavra this chama outro construtor, como se fosse uma herança
    public Aluno(string nome,int idade, string sexo, string aprovado):this(nome)
    {
       Idade = idade;  
       Sexo = sexo;
       Aprovado = aprovado;    
    }

    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;
}