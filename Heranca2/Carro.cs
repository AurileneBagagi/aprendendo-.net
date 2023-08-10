namespace Heranca2;

public class Carro: IVeiculo
{
    public int Gasolina { get; set; }

    public Carro(int gasolina){
        Gasolina = gasolina;
    }

    public void Dirigir(){
        if (Gasolina>0)
                Console.WriteLine("Dirigindo o carro...");
        else
            Console.WriteLine("Sem gasolina...");
    }
    public bool Abastecer(int QuantidadeG){
        Gasolina += QuantidadeG;
        return true;
    }
}