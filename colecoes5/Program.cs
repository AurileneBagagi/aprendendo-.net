using colecoes5;
// ------------------------------------------
Console.WriteLine("Questão 5");
List<Produto> Produtos = Adicionando.AddProduto(); //chamando o metodo que cria a lista

Relacao(Produtos);
Console.WriteLine("\n#### Adicionando a Mochila ####");
Produtos.Add(new Produto(){ Nome = "Mochila", Preco=22.44m});
// Produto mochila = new Produto() { Nome = "Mochila", Preco = 22.44m };
// Produtos.Add(mochila);
Relacao(Produtos);
Console.WriteLine("\n#### Ordenando ####");
// Para ordenar a lista de objetos é preciso usar o método OrderBy, e nele definir uma lambda, depois convertendo para Lista.
//IEnumerable
var ordenacao = Produtos.OrderBy(n=> n.Nome).ToList();
//se não convertemos o Ienumerable para lista, sempre que ele for chamado irá ser executado, então quando chamamos varias vezes ou mudanças dados é bom converte-lo em list.
// se o caso for pra procurar primeiro, é bom executar o ienumeration
// os ienumerable só são avaliados quando iterados (chamados)
Relacao(ordenacao);
Console.WriteLine("\n#### Preços abaixo de R$5,00 ####");
var localizando = Produtos.FindAll(n => n.Preco<5.00m);
Relacao(localizando);
Console.WriteLine("\n#### Localizando o estojo ####");
var estojo = Produtos.Find(n => n.Nome.Equals("Estojo"));
Console.WriteLine($"\nProduto : {estojo.Nome} - {estojo.Preco:c}");

static void Relacao(List<Produto> Produtos)
{
    decimal soma = 0.0m;
    Console.WriteLine("\n----- Relação de Produtos -----");
    Console.WriteLine("Nome\tPreço");
    foreach (var produto in Produtos) //para trabalhar com list não precisa do mesmo comportamento do arraylist
    {
        Console.WriteLine($"{produto.Nome}\t{produto.Preco:c}");
        soma+=produto.Preco;
    }
    Console.WriteLine($"\nSoma={soma:c}");
    Console.WriteLine($"Media={soma/Produtos.Count:c}");
    Console.WriteLine($"Quantidade de Produtos: {Produtos.Count}");
}

