namespace _17ProblemasHeranca;

public class Sardinha : Animal
{
    private readonly ComportamentoNadar _comportamentoNadar; // a propriedade é privada e somente leitura para não poder ser alterada após recever a instancia a instancia no momento

    public Sardinha(ComportamentoNadar comportamentoNadar)//costrutor
    {
        _comportamentoNadar = comportamentoNadar;
    }

    public void Locomocao()
    {
        Console.Write(nameof(Sardinha)); // produz o nome de uma variavel, tipo ou membro como a constante de cadeia e caracteres 
        _comportamentoNadar.Nadar();
    }
}
