namespace Heranca;

public class ContaInvestimento: ContaPoupanca
{
    public double Taxa { get; set; }=0.009;
    public double Imposto { get; set;}=0.001;
    private decimal CalculaImposto()
    {
        return Saldo* (decimal) Imposto;
    }
    public override decimal Depositar( decimal valor)
    {
        Saldo += valor;
        Saldo+=CalculaRemuneracao(Taxa); 
        return Saldo;
    }

    public override decimal Sacar(decimal valor)
    {
        if (Saldo-CalculaImposto()>=valor)
        {    
            Saldo= Saldo-valor-CalculaImposto(); 
            return Saldo;
        }
        else
            Console.WriteLine("Não é permitido que o saldo da conta fique negativo\n");
            return Saldo;

    }

}