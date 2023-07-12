namespace _11Heranca_abstract;

public abstract class Forma
{
    //propriedades
    public string? Cor { get; set; }
    public double Area { get; set; }    
    public double Perimetro { get; set; }

    //métodos abstratos, têm que serem implementadas  pela classe devirada 
    public abstract void CalcularArea(); //metodo para definir o valor da propriedade area
    public abstract void CalcularPerimetro(); //metodo para definir o valor da propriedade perimetro

    //método comum
    public string Descricao()
    {
        return "Sou a classe abstrata Forma";
    }
}
