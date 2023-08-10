namespace Resolucao9;

public class Quadrado : Forma
{
    private double Lado {get;set;}
    public Quadrado(double lado)
    {
        Lado = lado;
    }
    public override double Area()
    {
        return (Lado * Lado);
    }
}
