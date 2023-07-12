namespace Interfaces;

public class SalvarJson : ArquivoBase, Isalvar
{
    public override void Nome()
    {
        Console.WriteLine("Definir nome Json");
    }
    public void Salvar()
    {
        Console.WriteLine("Salvando arquivo Jsonw");
    }
    

}