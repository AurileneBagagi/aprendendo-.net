namespace Generic9;

internal class Aluno
{
    internal string? Nome { get; set; }
    internal int Idade { get; set; }
    internal char Sexo { get; set; }

    internal Aluno(string? nome, int idade, char sexo){
        Nome = nome;
        Idade = idade;
        Sexo = sexo;
    }

}