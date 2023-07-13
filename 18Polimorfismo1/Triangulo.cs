namespace _18Polimorfismo1;

public class Triangulo : Figura
{
    public override void Desenhar()
    {
        Console.WriteLine("Desenhando um triangulo..");
        base.Desenhar(); //está fazendo uma chamada ao metodo desenhar da classe base
    }
}
