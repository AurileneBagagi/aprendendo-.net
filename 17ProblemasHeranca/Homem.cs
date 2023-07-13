namespace _17ProblemasHeranca;

public class Homem : Animal
{
    private readonly ComportamentoAndar _comportamentoAndar; // a propriedade é privada e somente leitura para não poder ser alterada após recever a instancia a instancia no momento
    public Homem(ComportamentoAndar andar)//costrutor
    {
        _comportamentoAndar = andar;
    }
    public void Locomocao()
    {
        Console.Write(nameof(Homem));
        _comportamentoAndar.Andar();
    }
}
