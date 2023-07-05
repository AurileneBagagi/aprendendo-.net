using System.Runtime.InteropServices;

Console.WriteLine("=============== Instrução de Repetição Goto =================\n");

int i = 1;
    repetir: //label
    Console.WriteLine($"i={i}");
    i++;

if (i<=10)
    goto repetir;

Console.WriteLine("\nFim do processamento...");
Console.WriteLine($"i={i}");