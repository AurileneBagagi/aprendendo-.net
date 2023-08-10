Console.WriteLine("###### Questão 12 do exercicio de Generics ######");
int[] ints = {1,2,3,4,5};
string[] strings = {"Amanda", "Rael", "Dhony", "Auri", "Ana"};
double[] doubles = {1.1, 2.2, 3.3, 4.4, 5.5};

Console.WriteLine("-------Arrays de inteiros------");
Exemplo.ReverterEImplrimir<int>(ints);
Exemplo.ReverterEImplrimir(ints);

Console.ReadKey();

Console.WriteLine("-------Arrays de string------");
Exemplo.ReverterEImplrimir<string>(strings);
Exemplo.ReverterEImplrimir(strings);

Console.ReadKey();

Console.WriteLine("-------Arrays de string------");
Exemplo.ReverterEImplrimir<double>(doubles);
Exemplo.ReverterEImplrimir(doubles);

Console.ReadKey();

class Exemplo
{
    public static void ReverterEImplrimir<T>(T[] array){
        Array.Reverse(array);
        Console.WriteLine("Array Revertido");
        foreach (var item in array)
        {
            Console.Write(item + ", ");
        }
        Console.WriteLine("");
    }
}