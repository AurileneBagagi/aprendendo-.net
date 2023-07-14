namespace Heranca6;

public class Triangulo: Formas
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public Triangulo(double b, double altura){
        Base = b;
        Altura = altura;
    }

    public override double Area()=> (Base*Altura)/2;
}