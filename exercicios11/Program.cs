Console.WriteLine("Respontas equivalente ao exercicio 8 de Classes e Metodo");

Cliente cliente = new("Aurilene", "aurilene@email.com", 17);
Cliente.ExibirInfor(Email: cliente.Email, Nome: cliente.Nome, Idade: cliente.Idade);
Cliente.ExibirInfor(Email: cliente.Email, Nome: cliente.Nome);


public struct Cliente
{
    public string Nome;
    public string Email;
    private int idade;
    public int Idade
    {
        get => idade;
        set 
        {
            if (value <18)
                idade = 18;
            else
                idade = value;
        }
    }

    public Cliente (string nome, string email, int idade)
    {
        Nome = nome;
        Email = email;
        Idade = idade;
    }

    public static void ExibirInfor( string? Nome, string? Email, int Idade=18)
    {
        Console.WriteLine($"Nome = {Nome}, Email = {Email}, Idade = {Idade}");
    }
}
