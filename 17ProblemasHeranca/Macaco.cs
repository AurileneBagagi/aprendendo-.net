namespace _17ProblemasHeranca;

public class Macaco : Animal
{
    private readonly ComportamentoAndar _comportamentoAndar; // a propriedade é privada e somente leitura para não poder ser alterada após recever a instancia a instancia no momento

    public Macaco(ComportamentoAndar comportamentoAndar) //costrutor
    {
        _comportamentoAndar = comportamentoAndar;
    }

    public void Locomocao()
    {
        Console.WriteLine(nameof(Macaco));
        _comportamentoAndar.Andar();
    }
}
