
ClasseDerivada cd = new();
cd.VerificaAcesso();

Console.ReadKey();

public class ClasseDerivada : ClasseBase //chamada de herança
{
    public void VerificaAcesso()
    {
        Public_Membro();
        Protected_Membro();
        Protected_Internal_Membro();
        Internal_Membro();
        //Private_Membro(); //Não é possivel acessar ao metódo

        Console.WriteLine("\nAcesso ao campo private : private_var usando uma propriedade GET");
        int soma = public_var + protected_var + internal_var + Private_var; //já o campo private somente são acessiveis com as propriedades
        Console.WriteLine("\nTotal soma : " + soma);
    }
}

public class ClasseBase
{
    //campos
    public int public_var = 1;
    protected int protected_var = 2;
    internal int internal_var = 3;
    private int private_var = 4;

    //propriedade/Encapsulamento
    public int Private_var
    {
        get { return private_var; }
        set {  private_var = value;}
    }

    public void Public_Membro()
    {
        Console.WriteLine("ClasseBase - Método Public");
    }
    protected void Protected_Membro()
    {
        Console.WriteLine("ClasseBase - Método Protected");
    }
    internal void Internal_Membro()
    {
        Console.WriteLine("ClasseBase - Internal");
    }

    protected internal void Protected_Internal_Membro()
    {
        Console.WriteLine("ClasseBase - Método protected internal");
    }
    private void Private_Membro()
    {
        Console.WriteLine("ClasseBase - Método private");
    }
}