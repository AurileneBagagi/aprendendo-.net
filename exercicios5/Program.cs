
Console.WriteLine("Respontas equivalentes aos exercicios 2 e 3 Classes e Metodo");

Carros chevrolet = new("Sedan","Chevrolet");
Console.WriteLine("------------Chevrolet----------------");
Console.WriteLine($"Modelo = {chevrolet.Modelo}, Montadora = {chevrolet.Montadora}");
Carros ford = new("SUV","Ford", "EcoSport",2018,120);
Console.WriteLine("---------------Ford--------------");
Console.WriteLine($"Modelo = {ford.Modelo}, Montadora = {ford.Montadora}, Ano = {ford.Ano}, Potencia = {ford.Potencia}, Marca = {ford.Marca}");
ford.Acelerar(ford.Marca);
Console.WriteLine(ford.VelocidadeMaxima(ford.Potencia));
// Atividade pratica 3 de classes e métodos
Console.WriteLine("Aumentando potencia do Ford em 3");
var novaPotencia = ford.AumentarPotencia(ford.Potencia);
Console.WriteLine($"Nova potencia aumentada em 3: {ford.Potencia}");
// na passagem de argumento de parametro por valor o metodo recebe uma cópia, logo o valor alterado dentro do método é uma cópia e não o valor real, por isso o valor continua o mesmo.
ford.AumentarPotencia(ref ford.Potencia);
Console.WriteLine($"Nova potencia aumentada em 5: {ford.Potencia}");
//  na passagem de argumento de parametro por valor o metodo recebe a chave de referencia da memoria heap, logo o valor alterado dentro do método é alterado dentro do valor real, por isso o valor muda.

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
    // Atividade pratica 3 de classes e métodos
    public int AumentarPotencia(int potencia)
    {
        potencia+=3;
        return potencia;
    }
    public int AumentarPotencia( ref int potencia)
    {
        potencia+=5;
        return potencia;
    }
}

