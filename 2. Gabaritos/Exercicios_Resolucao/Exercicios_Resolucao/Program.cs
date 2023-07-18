
Carro carro = new Carro(0);

Console.WriteLine("Informe quantos litros de gasolina: ");

int gasolina = Convert.ToInt32(Console.ReadLine());

if (carro.Abastecer(gasolina))
{
    carro.Dirigir();
}

Console.ReadKey();

public interface IVeiculo
{
    void Dirigir();
    bool Abastecer(int quantidade);
}

class Carro : IVeiculo
{
    public int Gasolina { get; set; }

    public Carro(int gasolina)
    {
        Gasolina = gasolina;
    }

    public void Dirigir()
    {
        if (Gasolina > 0)
        {
            Console.WriteLine("Dirigindo o carro...");
        }
        else
        {
            Console.WriteLine("Sem gasolina...");
        }
    }

    public bool Abastecer(int quantidade)
    {
        Gasolina += quantidade;
        return true;
    }
}