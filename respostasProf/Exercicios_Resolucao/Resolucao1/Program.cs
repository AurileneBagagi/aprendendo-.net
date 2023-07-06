int total = 3;
Pessoa[] pessoas = new Pessoa[total];

Console.WriteLine("Informe o nome de 3 Pessoas");
for (int i = 0; i < total; i++)
{
    pessoas[i] = new Pessoa()
    {
        Nome = Console.ReadLine()
    };
}

Console.WriteLine("\nAcessando os dados...\n");
for (int i = 0; i < total; i++)
{
    Console.WriteLine(pessoas[i].ToString());
}

Console.ReadLine();

public class Pessoa
{
    public string? Nome { get; set; }

    public override string ToString()
    {
        return "Ola! Meu nome é " + Nome;
    }
}
