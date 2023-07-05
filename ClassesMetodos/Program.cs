Console.WriteLine("## Classes e Objetos ##\n");
//para declarar pode usar a sintaxe do nome da classe ou "var", ex.: var p1 = new Pessoa();
//para declarar usando a sintaxe do nome da classe pode usar apenas o new, ex.: Pessoa p1 = new()

Pessoa p1 = new Pessoa();

p1.nome = "Maria";
p1.idade = 25;
p1.sexo = "feminino";

Console.WriteLine($"{p1.nome} {p1.idade} {p1.sexo}");


Console.ReadKey();

class Pessoa
{
    public string? nome;
    public int idade;
    public string? sexo;
}