using _14LINQAgrupamento1;
var listaProdutos = Produto.GetProdutos();

Console.WriteLine("------ Ordenando apenas as categorias ----------------\n");
var produtosCategoria = listaProdutos.GroupBy(p => p.Categoria)
                                        .OrderBy(c=>c.Key) //ordenando por categoria, que foi nomeado chave a cima
                                        ;
                                         

foreach (var grupo in produtosCategoria)
{
    Console.WriteLine(grupo.Key+ ":\t"+ grupo.Count());

    foreach (var produto in grupo)
    {
        Console.WriteLine($"  {produto.Nome} \t{produto.Preco:C2} \t{produto.Estoque}");
    }
}

Console.WriteLine("\n------ Ordenando as categorias e os produtos ----------------\n");
var produtosECategoria = listaProdutos.GroupBy(p => p.Categoria)
                                        .OrderBy(c=>c.Key) //ordenando por categoria, que foi nomeado chave a cima
                                        .Select(g=> new //selecionando os Produtos
                                        {
                                            Categoria = g.Key,
                                            Produtos = g.OrderBy(p=>p.Nome).Select(p => new
                                            {
                                                p.Nome,
                                                p.Preco,
                                                p.Estoque
                                                 
                                            })

                                        }

                                        );
                                         

foreach (var grupo in produtosECategoria)
{
    //Console.WriteLine(grupo.Key+ ":\t"+ grupo.Count());
    Console.WriteLine(grupo.Categoria+ ":\t"+ grupo.Produtos.Count());

    foreach (var produto in grupo.Produtos)
    {
        Console.WriteLine($"  {produto.Nome} \t{produto.Preco:C2} \t{produto.Estoque}");
    }
}

Console.ReadKey();