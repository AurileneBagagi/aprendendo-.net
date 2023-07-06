namespace Resolucao9;

public class Circulo : Forma
{
    private double Raio { get; set; }
    public Circulo(double raio)
    {
        Raio = raio;
    }
    public override double Area()
    {
        return (Math.PI * Raio * Raio);
    }
}
