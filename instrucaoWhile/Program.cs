Console.WriteLine("=============== Instrução de Repetição While True =================");
Console.WriteLine("Impar ou par");

while(true)
{
    Console.Write("\nInforme um numero inteiro (Diigite 0 para sair): ");
    int numero = Convert.ToInt32(Console.ReadLine());

    if (numero == 0)
    {
        break;
    }
    if (numero%2==0)
        Console.WriteLine($"{numero} é par");
    else
     Console.WriteLine($"{numero} é impar");
    
}

Console.WriteLine("\nFim do processamento...");

Console.WriteLine("=============== Instrução de Repetição While Aninhado =================");

int x = 0;
while (x<5)
{
    int y=0;
    while (y<5)
    {
        Console.Write($"({x},{y}) ");
        y++;
    }
    x++;
    Console.WriteLine();
}

Console.WriteLine("\nFim do processamento...");