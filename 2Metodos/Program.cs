Console.WriteLine("## Métodos ##\n");

MinhaClasse minhaClasse = new MinhaClasse();

minhaClasse.Saudacao();
//minhaClasse.ExibirDataAtual();

Console.ReadKey();


class MinhaClasse
{
    public void Saudacao()
    {
        Console.WriteLine("Bem-Vindo");
        ExibirDataAtual(); //chamando um metódo de outro método
    }

    public void ExibirDataAtual() => //Quando tiver apenas um método.
        Console.WriteLine(DateTime.Now.ToShortDateString());
}