Console.WriteLine("=============== Instrução de Repetição do-While =================");

var i=1;
do
{
    Console.WriteLine($"i={i}");
    i++;
}
while (i<=10);
Console.WriteLine("=============== Instrução de Repetição do-While BreaK =================");

var a=1;
do
{
    Console.WriteLine($"a={a}");
    a++;
    if (a>10)
        break;
}
while (true);

Console.WriteLine("=============== Instrução de Repetição do-While Aninhado =================");

int x=0;
do
{
    int y=0;
    do
    {
        Console.Write($"({x},{y})");
        y++;
    }
    while (y<5);
    x++;
    Console.WriteLine();
}
while (x<5);

Console.WriteLine("\nFim do processamento...");