using System.Collections;
using colecoes4;
// ------------------------------------------

Console.WriteLine("Questão 4");
ArrayList list = new ArrayList();

Adicionando(list);
Exibindo(list);
Adicionando(list);
Exibindo(list);
Console.WriteLine("----- Removendo Valor Final ------");
list.RemoveAt(list.Count-1);
Exibindo(list);


static void Exibindo(ArrayList list)
{
    Console.WriteLine("----- Componentes da Lista ------");
    foreach (Pessoas pessoa in list) //no caso de objeto, chama a classe.
    {
        Console.WriteLine(pessoa.Exibir());
    }
}

static void Adicionando(ArrayList list)
{
    Console.WriteLine("----- Adicionando pessoas ------");
    Console.Write("Quantas pessoas você quer adicionar: ");
    int q = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < q; i++)
    {
        Console.Write("\nNome: ");
        string nome = Console.ReadLine();
        Console.Write("Idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        list.Add(new Pessoas() //adição de objeto por vez
        {
            Nome = nome,
            Idade = idade,
        });
    }
}