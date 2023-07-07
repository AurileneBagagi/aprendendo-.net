Console.WriteLine("Respontas equivalente ao exercicio 7 de Classes e Metodo");

Carros chevrolet = new("Sedan","Chevrolet","Onix",1999,110);
Console.WriteLine("------------Chevrolet----------------");
chevrolet.ExibirInfo(modelo: chevrolet.Modelo, montadora: chevrolet.Montadora, marca: chevrolet.Marca, potencia: chevrolet.Potencia, ano: chevrolet.Ano);


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

public Carros(string? Modelo, string? Montadora, string? Marca, int Ano, int Potencia) //construtor
    {
        this.Modelo = Modelo;
        this.Montadora = Montadora;
        this.Marca = Marca;
        this.Ano = Ano;
        this.Potencia = Potencia;
    }

    public void ExibirInfo(string? modelo, string? montadora, string? marca, int potencia, int ano = 2023)
    { //metódo com parametros opcionais
        Console.WriteLine($"Modelo = {modelo}, Montadora = {montadora},  Marcar = {marca}, Potencia = {potencia} Ano = {ano}");
    }


}

// o campo tem o compartilhamento de dados mais publico, sem controle de acesso e mudanças, já a propriedade garante que os dados sejam acessados com facilidade e ainda ajuda a promover segurança e controle dos dados.
//correção - as propriedades permitem que uma classe exponha uma forma pública de obter e definir valores, qquando oculta o código de implementação ou de verificação;
// um campo é uma variavel de qualquer tipo que é declarada diretamente na classe;
// uma propriedade é um membro que fornece um mecanismo flexivel para ler, gravar ou calcular um valor de um campo privado.