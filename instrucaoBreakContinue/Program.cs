Console.WriteLine("=============== Instrução Continue =================");

for (int i = 1; i <= 10; i++) //caso queira incrementar +2 seria i+=2
{
    if (i == 4)
        continue;
    Console.WriteLine(i);
}

Console.WriteLine("\nFim do processamento...");
Console.WriteLine("=============== Instrução Break e Continue =================");

for (int a = 1; a <= 10; a++) //caso queira incrementar +2 seria i+=2
{
    if (a == 5)
        continue;
    if (a >8)
        break;
    Console.WriteLine(a);
}

Console.WriteLine("\nFim do processamento...");