Console.WriteLine("## Métodos - Parâmetro Objetos (atribuições) ##\n");

Aluno al = new();
al.Consultar();

Console.ReadKey();

public class Aluno
{
    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;

    public void Consultar()
    {
        var aluno = new Aluno(); //não precisa ter o mesmo nome do objeto que chama;

        Console.WriteLine("Nome : ");
        aluno.Nome = Console.ReadLine();
        Console.WriteLine("Idade : ");
        aluno.Idade = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Sexo : ");
        aluno.Sexo = Console.ReadLine();
        Console.WriteLine("Aprovado (S)im (N)ão : ");
        aluno.Aprovado = Console.ReadLine();

        Curso curso = new();
        curso.Resultado(aluno);
    }
}

public class Curso
{
    public void Resultado(Aluno al)//recebe como parametro um objeto qualquer, o nome aqui não precisa ser o mesmo do objeto, é apenas para manipular o objeto
    {
        Console.WriteLine($"\nO aluno {al.Nome}, sexo {al.Sexo} com {al.Idade} anos");
        if(al.Aprovado == "S")
            Console.WriteLine("\n foi Aprovado");
        else
            Console.WriteLine("\n foi Reprovado");
    }
}
