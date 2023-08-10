Console.WriteLine("#### Questão 10 do Exercicio de Delegate,Lambda e LINQ ####");

Console.WriteLine("--------- Exercicio 1 - Where ----------------");
string[] nomes = { "angel", "dhony", "moises", "felipe", "tatiane", "emanuel", "costa", "gomes"};
var resultado = nomes.Where(n => n.Contains('a'));

Exibir(resultado);

Console.WriteLine("\n--------- Exercicio 2 - OrderBy ----------------");
int[] num = {13,7654,1,18,15,21,20,87643,1543};
var resultado2 = num.OrderBy(n=>n);
Exibir(resultado2);

Console.WriteLine("\n--------- Exercicio 3 - GroupBy ----------------");
string[] palavras = { "banana", "abacaxi", "uva","Kiwi", "laranja", "abacate", 
"maça", "pera" }; 

var resultado3 = palavras.GroupBy(n => n.Length);

foreach (var item in resultado3)
{
    Console.WriteLine($"Palavras de tamalho\t{item.Key}:");
    Exibir(item);
}

Console.WriteLine("\n--------- Exercicio 4 - FirstOrDefault ----------------");
int resultado4 = num.FirstOrDefault(n => n%2==0);
Console.WriteLine("Primeiro nomero par: "+ resultado4);

static void Exibir<T>(IEnumerable<T> resultado)
{
    foreach (var item in resultado)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}

