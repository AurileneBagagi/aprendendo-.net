
List<string> nomes = new List<string>();
nomes.Add("Maria");
nomes.Add("Miriam");
nomes.Add("Paulo");
nomes.Add("Carlos");

//string resultado = nomes.Find(VerificaNomeNaLista); // chama o linq para uma função Verfica nome na lista que retornaria um valor booleano se a afirmação for verdadeira no primeiro que encontra;

string resultado = nomes.Find(delegate (string? nome) // função anonima usando o delegate
{
    return nome.Equals("Paulo");
});

Console.WriteLine(resultado);

Console.ReadKey();