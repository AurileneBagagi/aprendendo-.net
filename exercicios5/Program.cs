Console.WriteLine("Classe Carros");

Carros chevrolet = new("Sedan","Chevrolet");
Console.WriteLine("----------------------------------");
Console.WriteLine($"Modelo = {chevrolet.Modelo}, Montadora = {chevrolet.Montadora}");
Carros ford = new("SUV","Ford", "EcoSport",2018,120);
Console.WriteLine("----------------------------------");
Console.WriteLine($"Modelo = {ford.Modelo}, Montadora = {ford.Montadora}, Ano = {ford.Ano}, Potencia = {ford.Potencia}, Marca = {ford.Marca}");
ford.Acelerar(ford.Marca);
Console.WriteLine(ford.VelocidadeMaxima(ford.Potencia));

public class Carros
{

    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Ano;
    public int Potencia;

    public Carros(string? Modelo, string? Montadora)
    {
        this.Modelo = Modelo;
        this.Montadora = Montadora;
    }
    public Carros(string? Modelo, string? Montadora, string? Marca, int Ano, int Potencia):this(Modelo,Montadora)
    {
        this.Marca = Marca;
        this.Ano = Ano;
        this.Potencia = Potencia;
    }

    public void Acelerar(string? marca)
    {
        Console.WriteLine($"Acelerando o meu {marca}");
    }
    public double VelocidadeMaxima(int potencia)
    {
        return  potencia*1.75;
    }

}

