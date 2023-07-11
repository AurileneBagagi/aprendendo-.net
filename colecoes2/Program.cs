// ------------------------------------------

Console.WriteLine("Questão 2");
Console.Write("Qual o tamanho do array? ");
int t = Convert.ToInt32(Console.ReadLine());
int[] intis = new int[t];

for (int i = 0; i<t; i++)
{
    Console.Write($"\nQual o numero a ser adicionado no campo Array[{i}]? ");
    intis[i] = Convert.ToInt32(Console.ReadLine());
}
string x;
Console.WriteLine("\nEncontrando Valores no Array (Digite 'fim' para sair) ");
do
{
    Console.Write("\nQual o numero a ser encontrado no Array? (Digite 'fim' para sair) ");
    x = Console.ReadLine();
    if (x != "fim")
    {
        int v = Convert.ToInt32(x); 
        if(Array.BinarySearch(intis,v)>=0)
            Console.WriteLine("\nO valor está na lista");
        else
            Console.WriteLine("O valor não está na lista");
    }
}
while(x !="fim");