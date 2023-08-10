try {
    int? saldo = null; 
    int valorSaque = 50; 
    if (valorSaque > saldo) 
    {
        throw new SaldoInsuficienteException("O saldo é insuficiente para este saque.");
    } 
    saldo -= valorSaque; 
    Console.WriteLine("Saque efetuado com sucesso. Novo saldo: " + saldo);
} 
catch (SaldoInsuficienteException e) 
{
    Console.WriteLine("Erro: " + e.Message); 
}

public class SaldoInsuficienteException : Exception
{
    public SaldoInsuficienteException(){}
    public SaldoInsuficienteException(string message) : base(message)
    {}
    public SaldoInsuficienteException(string message, Exception inner) : base(message, inner)
    {}


}