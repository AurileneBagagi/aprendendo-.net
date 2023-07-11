// ------------------------------------------
Console.WriteLine("\nQuestão 1");
string[] frutas = { "Maça", "Banana", "Laranja", "Uva", "Manga", "Pêra", "Abacate", "Mamão", "Pêssego", "Amora" };

BuscarFor(frutas);
Buscar(frutas);

Console.WriteLine("\n\n----- Segunda e Penultima Fruta -----");
Console.WriteLine($"{frutas[8]}");
Console.WriteLine($"{frutas[1]}");
Console.WriteLine("\n\n----- Mudando os nomes -----");
frutas[2] = "Kiwi";
frutas[9] = "Caqui";
Buscar(frutas);
Console.WriteLine("\n\n----- ordenando -----");
Array.Sort(frutas);
Buscar(frutas);
Console.WriteLine("\n\n----- revertendo -----");
Rever(frutas);

static void Buscar(string[] frutas)
{
    Console.WriteLine("\n\n----- foreach -----");

    foreach (string item in frutas)
    {
        Console.Write($"{item}\t");
    }
}

static void BuscarFor(string[] frutas)
{
    Console.WriteLine("----- Loop For -----");
    for (int i = 0; i < frutas.Length; i++)
    {
        Console.Write($"{frutas[i]}\t");
    }
}

static void Rever(string[] frutas)
{
    for (int i=(frutas.Length-1); i>= 0;i--)
    {
        Console.Write($"{frutas[i]}\t");
    }
}
