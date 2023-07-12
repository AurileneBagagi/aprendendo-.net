namespace Interfaces;

public class SalvarXml : ArquivoBase, Isalvar
{
    public override void Nome()
    {
        Console.WriteLine("Definir nome Json");
    }
    public void Salvar()
    {
        Console.WriteLine("Salvando arquivo XML");
    }


}