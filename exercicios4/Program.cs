// See https://aka.ms/new-console-template for more information
Console.WriteLine("Classe Carros");

Carros chevrolet = new("Sedan","Chevrolet","Onix",2016,110);
Console.WriteLine("----------------------------------");
Console.WriteLine($"Modelo = {chevrolet.Modelo}, Montadora = {chevrolet.Montadora}, Ano = {chevrolet.Ano}Potencia = {chevrolet.Potencia}, Marca = {chevrolet.Marca}");
chevrolet.Acelerar(chevrolet.Marca);
Carros ford = new("SUV","Ford", "EcoSport",2018,120);
Console.WriteLine("----------------------------------");
Console.WriteLine($"Modelo = {ford.Modelo}, Montadora = {ford.Montadora}, Ano = {ford.Ano}, Potencia = {ford.Potencia}, Marca = {ford.Marca}");
ford.Acelerar(ford.Marca);

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

    public void Acelerar(string marca)
    {
        Console.WriteLine($"Acelerando o meu {marca}");
    }
}
