namespace Heranca6;

public class Circulo: Formas
{
    public double Raio { get; set; }

    public Circulo(double raio){
        Raio = raio;
    }

    public override double Area()=> Raio*Raio*Math.PI;
}