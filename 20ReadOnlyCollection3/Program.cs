using System.Collections.ObjectModel;
Console.ReadKey();
// não peritir que haja alteração do ReadOnlyCollection por meio do tipo complexo
public class GerenciaExoPlanetas
{
    private List<ExoPlaneta>? exoPlanetas = ExoPlaneta.GetExoPlanetas(); //deixar a lista privada 

    public ReadOnlyCollection<ExoPlaneta> ExoPlanetas //permitir somente leitura
    {
        get { return exoPlanetas.AsReadOnly(); }
    }
    public void AdicionaPlaneta(ExoPlaneta planeta) //é a unica forma de adicionar
    {
        exoPlanetas.Add(planeta);
    }
}
public class ExoPlaneta
{
    public string? Nome { get; set; }
    public static List<ExoPlaneta> GetExoPlanetas()
    {
        return new List<ExoPlaneta>()
        {
          new ExoPlaneta() { Nome = "Proxima Centauri b" },
          new ExoPlaneta() { Nome = "Kleper 186-f" },
          new ExoPlaneta() { Nome = "Gliesi 1061-c" },
        };
    }
}