using Exercicio5;
List<Produto> Produtos = FonteDados.GetProdutos();
ExibirProdutos(Produtos);

Console.WriteLine("\nIncluindo um novo produto : Mochila (R$ 22,44)");
Produto mochila = new Produto() { Nome = "Mochila", Preco = 22.44m };
Produtos.Add(mochila);
ExibirProdutos(Produtos);

Console.WriteLine("\nLocalizando o produto : Estojo ...");
var produto1 = Produtos.Find(n => n.Nome.Equals("Estojo"));
Console.WriteLine($"\nProduto : {produto1.Nome} - {produto1.Preco}");

Console.WriteLine("\nOrdenando o produto por nome...");
//Produtos.Sort();
var listaOrdenada = Produtos.OrderBy(n => n.Nome).ToList();
ExibirProdutos(listaOrdenada);

Console.WriteLine("\nLocalizando e exibindo produtos com preço inferior a R$ 5,00");
var ProdutosMenorCinco = Produtos.FindAll(n => n.Preco <= 5.00m);
Console.Write("\nProdutos com preço menor que R$ 5.00\n");
foreach (var item in ProdutosMenorCinco)
{
    Console.WriteLine($"{item.Nome}\t{item.Preco}");
}

Console.ReadKey();

static void ExibirProdutos(List<Produto> Produtos)
{
    Console.WriteLine("\nRelação de Produtos\n");
    Console.WriteLine("\nNome\tPreço");

    var somaPreco = 0.0m;
    foreach (var item in Produtos)
    {
        Console.WriteLine($"{item.Nome}\t{item.Preco}");
        somaPreco += item.Preco;
    }

    var mediaPreco = somaPreco / Produtos.Count();
    Console.WriteLine($"\nMédia dos preços : {Math.Round(mediaPreco, 2)}");
    Console.WriteLine($"\nTotal de Produtos : {Produtos.Count()}");
}