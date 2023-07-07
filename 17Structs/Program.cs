Console.WriteLine("## Structs ##\n");

// é ideal utilizar structs quando:
 // 1: se as instancias do tipo forem pequenas e normalmente de curta duração
 // 2: representa logicamente em um unico valor, semelhante ao tipos primitivos (int, double etc)
 // 3: é imutavel
 // 4: não precisa sofrer conversão para tipo de referencia (boxing) com frequência;
Cliente cliente = new();
cliente.Nome = "Maria";
cliente.Idade = 19;

Console.WriteLine($"{cliente.Nome} {cliente.Idade}");

Console.ReadKey();

public struct Cliente
{
    public string? Nome { get; set; }
    public int Idade { get; set; }

    public Cliente(string? nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}