namespace Heranca;

public class ContaPoupanca: ContaCorrente
{
    public override double Juros { get; set; } = 0.005;

    public override decimal Sacar(decimal valor)
    {
        if (Saldo>=valor)
        {    
            Saldo-=valor;
            return Saldo;
        }
        else
            Console.WriteLine("Não é permitido que o saldo da conta fique negativo\n");
            return Saldo;

    }
}