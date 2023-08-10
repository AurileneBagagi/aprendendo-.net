namespace Heranca;

public class ContaCorrente
{
    public int Numero { get; set; }
    public string Nome { get; set; }=string.Empty;
    public decimal Saldo { get; set; }=0.0m;
    public virtual double Juros { get; set; }=0;

    internal decimal CalculaRemuneracao(double juros)
    {
        return Saldo* (decimal) juros;
    }

    public virtual decimal Depositar( decimal valor)
    {
        Saldo += valor;
        Saldo+=CalculaRemuneracao(Juros); 
        return Saldo;
    }
    public virtual decimal Sacar(decimal valor)
    {
        Saldo-=valor;
        return Saldo;
    }
    public void ExibirSaldo()
    {
        Console.WriteLine($"O saldo total da sua conta é {Saldo:c}");
    }
    public void Exibir()
    {
        Console.WriteLine($"Nome:{Nome}\tConta:{Numero}\tSaldo:{Saldo:c}");
    }
}