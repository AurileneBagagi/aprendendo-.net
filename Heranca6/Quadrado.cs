namespace Heranca6;

public class Quadrado: Formas
{
    public double Lado { get; set;}
    public Quadrado(double lado){
        Lado = lado;
    }

    public override double Area()=> Lado*Lado;
}