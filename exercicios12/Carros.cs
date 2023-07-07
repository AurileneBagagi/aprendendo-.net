namespace exercicios12; //o ideal é que não tenha o mesmo nome da classe.
public class Carros
{

    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    private int ano;
    public int Ano 
    {
        get {return ano;} 
        set 
        {
            if (value <2000)
                ano = 2000;
            else if (value >2022)
                ano = 2022;
            else 
                ano = value;
        }
    }
    public int Potencia;
    public static double ValorIpva; // campo estatico
    public int Cor;

    public Carros(string? Modelo, string? Montadora)
    {
        this.Modelo = Modelo;
        this.Montadora = Montadora;
    }
    public Carros(string? Modelo, string? Montadora, string? Marca, int Ano, int Potencia, int cor):this(Modelo,Montadora)
    {
        this.Marca = Marca;
        this.Ano = Ano;
        this.Potencia = Potencia;
        Cor = cor;
    }
    public static void ObterValor() // metódo estático
    {
        ValorIpva = 4;
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
    public int AumentarPotenciaVelocidade(int potencia, out double velocidade)
    {
        potencia+=7;
        velocidade = potencia*1.75;
        return potencia;

    }
    public void ExibirInfo(string? modelo, string? montadora, string? marca, int potencia, int ano = 2023, int cor=1)
    {
        Console.WriteLine($"Modelo = {modelo}, Montadora = {montadora},  Marcar = {marca}, Potencia = {potencia}, Ano = {ano}, Cor = {(Cores)cor}");
    }
}