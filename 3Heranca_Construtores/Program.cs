
Aluno aluno1 = new();
Aluno aluno2 = new("José");

Console.ReadKey();

//base
class Pessoa
{
    public Pessoa() //será chamado primeiro pela derivada Aluno
    {
        Console.WriteLine("Construtor da classe Pessoa");
    }
    public Pessoa(string nome)
    {
        Console.WriteLine("Construtor da classe Pessoa com parametro");
    }
}

//derivada
class Aluno : Pessoa //herança
{
    public Aluno() : base() 
    { // (sem e com o base) será chamado depois do costrutor sem parametros da classe base 
        Console.WriteLine("Construtor da classe Aluno");
    }
    public Aluno(string nome) : base(nome) 
    { //Com base ele não sera chamado depois do construtor sem parametro, mas sim depois do consultor com parametros
        Console.WriteLine("Construtor da classe Aluno com parametro");
    }
}