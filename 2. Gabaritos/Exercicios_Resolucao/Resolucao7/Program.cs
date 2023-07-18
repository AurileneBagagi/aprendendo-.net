
Filha ofilha = new Filha();

Console.ReadKey();
class Pai
{
    Filha ofilha = new Filha();
    public Pai()
    {
        Console.WriteLine("Construtor Pai");
    }
}
class Filha : Pai
{
    public Filha()
    {
        Console.WriteLine("Construtor Filha");
    }
    //Pai opai = new Pai();
}
