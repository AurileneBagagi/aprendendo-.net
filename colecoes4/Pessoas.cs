namespace colecoes4;

public class Pessoas
{
    public string Nome { get; set; } = String.Empty;
    public int Idade { get; set;}

    public string Exibir() //no caso de só exibir, tem-se que retornar como string
    {
       return(Nome+" - "+Idade);
    }
}
