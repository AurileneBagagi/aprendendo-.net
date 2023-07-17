

Stack<int> numeros = new Stack<int>();
numeros.Push(10);
numeros.Push(20);
numeros.Push(30);
numeros.Push(10);

Console.WriteLine($"-A pilha original contém {numeros.Count} itens");

ExibirPilha(numeros);

//retorna sem remover
Console.WriteLine($"\n-Item obtido da pilha (Peek)  : {numeros.Peek()}");

//remove e retorna
Console.WriteLine($"\n-Item Removido da pilha (Pop) : {numeros.Pop()}");

Console.WriteLine($"\n-A pilha agora contém {numeros.Count} itens");

if(numeros.Contains(20))
    Console.WriteLine("\n-Item 20 esta na pilha");
else
    Console.WriteLine("\n-Item 20 não esta na pilha");

Console.WriteLine("\n-Copia a pilha usando ToArray");
var copia = new Stack<int>(numeros.ToArray());
ExibirPilha(copia);

Console.WriteLine("\n-Removendo todos os itens da pilha\n");
numeros.Clear();
Console.WriteLine($"{numeros.Count} itens na pilha");

ExibirPilha(numeros);

Console.ReadKey();

static void ExibirPilha<T>(IEnumerable<T> numeros) //especificando te forma generica o IENUMERABLE pois não se preocupo com a coleção que eu estou recebendo aqui, porque qualquer coleção que implementar pode sr iterado

//O termo "iterado" se refere ao ato de percorrer ou iterar(repetir) sobre uma sequência de elementos em um loop, geralmente aplicando uma determinada ação ou operação em cada elemento

o número vai poder ser alterado.
{
    Console.WriteLine();
    foreach (var item in numeros)
    {
        Console.WriteLine(item);
    }
}