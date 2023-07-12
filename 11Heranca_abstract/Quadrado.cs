namespace _11Heranca_abstract;

public class Quadrado : Forma
{
    //A propriedades area e Perimentos são da classe abstratas
    public double Lado { get; set; }
    public override void CalcularArea()
    { //metodo para definir o valor da propriedade area
        Area = Lado * Lado;
    }

    public override void CalcularPerimetro()
    {//metodo para definir o valor da propriedade perimetro
        Perimetro = 4 * Lado;
    }
}
