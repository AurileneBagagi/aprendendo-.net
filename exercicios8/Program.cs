Console.WriteLine("Respontas equivalente ao exercicio 5 de Classes e Metodo");

Carros chevrolet = new("Sedan","Chevrolet","Onix",2016,110);
Console.WriteLine("------------Chevrolet----------------");
chevrolet.ExibirInfo(modelo: chevrolet.Modelo, montadora: chevrolet.Montadora, marca: chevrolet.Marca, potencia: chevrolet.Potencia);
chevrolet.ExibirInfo(modelo: chevrolet.Modelo, montadora: chevrolet.Montadora, marca: chevrolet.Marca, potencia: chevrolet.Potencia, ano: chevrolet.Ano);

public class Carros
{

    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Ano;
    public int Potencia;

public Carros(string? Modelo, string? Montadora, string? Marca, int Ano, int Potencia)
    {
        this.Modelo = Modelo;
        this.Montadora = Montadora;
        this.Marca = Marca;
        this.Ano = Ano;
        this.Potencia = Potencia;
    }

    public void ExibirInfo(string? modelo, string? montadora, string? marca, int potencia, int ano = 2023)
    {
        Console.WriteLine($"Modelo = {modelo}, Montadora = {montadora},  Marcar = {marca}, Potencia = {potencia} Ano = {ano}");
    }
}
 // Os parametros opcionais são parametros que você pde omitir na chamada do metódo, eles devem ser definidos com um valor padrão constante e depois da definição dos parametros obrigatorios;
 // Os argumentos nomeados permitem que você especifique um argumento para um parametro correspondendo o paramero com o seu nome em vez de com sa posição na lista de parametros;