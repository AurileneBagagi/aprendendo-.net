Console.WriteLine("Respontas equivalente ao exercicio 6 de Classes e Metodo");

Carros chevrolet = new("Sedan","Chevrolet","Onix",2016,110);
Console.WriteLine("------------Chevrolet----------------");
chevrolet.ExibirInfo(modelo: chevrolet.Modelo, montadora: chevrolet.Montadora, marca: chevrolet.Marca, potencia: chevrolet.Potencia, ano: chevrolet.Ano);
Carros.ObterValor();
Console.WriteLine($"IPVA = {Carros.ValorIpva:c}"); // o correto é exibir como % e não real, mas aí está uma alternativa de exibição;

//z - a palavra representa que um metodo/campo/propriedade/operador/evento/construtor não dependem de um objeto/instancia para ser acessaados, pois pertecem as classes e não aos objetos. Mas não podem usar variaveis de instancia.
//correção - o modificadr static permite declarar um membro estático que pertence ao proprio tipo e não a um objeto especificio. Ele pode ser usado para declarar classes, structs e interfaces

public class Carros
{

    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Ano;
    public int Potencia;
    public static double ValorIpva; // campo estatico

public Carros(string? Modelo, string? Montadora, string? Marca, int Ano, int Potencia) //construtor
    {
        this.Modelo = Modelo;
        this.Montadora = Montadora;
        this.Marca = Marca;
        this.Ano = Ano;
        this.Potencia = Potencia;
    }

    public static void ObterValor() // metódo estático
    {
        ValorIpva = 4;
    }
    public void ExibirInfo(string? modelo, string? montadora, string? marca, int potencia, int ano = 2023)
    { //metódo com parametros opcionais
        Console.WriteLine($"Modelo = {modelo}, Montadora = {montadora},  Marcar = {marca}, Potencia = {potencia} Ano = {ano}");
    }


}