namespace Heranca5;

public class Pessoa
{
    protected string Nome { get; set; }
    public Pessoa (string nome){
        Nome = nome;
    }
    public override string ToString()
    {
        return "Meu nome é "+ Nome;
    }

}