Console.WriteLine("Respontas equivalente ao exercicio 4 de Classes e Metodo");

Carros chevrolet = new("Sedan","Chevrolet","Onix",2016,110);
Console.WriteLine("------------Chevrolet----------------");
Console.WriteLine($"Modelo = {chevrolet.Modelo}, Montadora = {chevrolet.Montadora}, Ano = {chevrolet.Ano}");

var newPotential = chevrolet.AumentarPotenciaVelocidade(chevrolet.Potencia, out double velocidade);
Console.WriteLine($"Nova potencia: {newPotential}");
Console.WriteLine($"Velocidade: {velocidade}");

//a palavra-chave out é usada para passar um argumento por referencia igual ao ref, mas o argumento pode ser passado sem atribuir valor nenhum a ele. Um argumento que é passado usando out deve ser inicializado no metódo chamado antes de retornar ao metodo chamador. Podendo-se ser usado paara passar mais de um retorno.
public class Carros
{

    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Ano;
    public int Potencia;

public Carros(string Modelo, string Montadora, string Marca, int Ano, int Potencia)
    {
        this.Modelo = Modelo;
        this.Montadora = Montadora;
        this.Marca = Marca;
        this.Ano = Ano;
        this.Potencia = Potencia;
    }

    public int AumentarPotenciaVelocidade(int potencia, out double velocidade)
    {
        potencia+=7;
        velocidade = potencia*1.75;
        return potencia;

    }
}
