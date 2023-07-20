Console.WriteLine("Questão 7 do Exercicio de Delegate,Lambda e LINQ");

List<Planeta> planetas = new List<Planeta> 
{ 
    new Planeta("Mercúrio", 4879, 3.301e23), 
    new Planeta("Vênus", 12104, 4.867e24), 
    new Planeta("Terra", 12756, 5.972e24), 
    new Planeta("Marte", 6792, 6.39e23), 
    new Planeta("Júpiter", 142984, 1.898e27), 
    new Planeta("Saturno", 120536, 5.683e26), 
    new Planeta("Urano", 51118, 8.681e25), 
    new Planeta("Netuno", 49528, 1.024e26) 
};

Predicate<Planeta> predicate = p => p.Diametro>100000;
List<Planeta> planetas100k = UsandoPredicate(planetas,predicate);

foreach (var item in planetas100k)
{
    Console.WriteLine(item.Nome);
}

static List<Planeta> UsandoPredicate(List<Planeta> planetas, Predicate<Planeta> predicate)
{
    var resulado = new List<Planeta>();
    foreach (var planeta in planetas)
    {
        if (predicate(planeta))
            resulado.Add(planeta);
    }
    return resulado;
}


public class Planeta
{
    public string Nome { get; set; }
    public double Diametro { get; set; }
    public double Massa { get; set; }

    public Planeta(string nome, double diametro, double massa)
    {
Nome = nome;
        Diametro = diametro;
        Massa = massa;
    }
}