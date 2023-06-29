// See https://aka.ms/new-console-template for more information
Console.WriteLine("##Leitura de Nullable Types ##\n");
//=============================== COMANDOS INTERESSANTES =======================================
int? i = 100;

if(i.HasValue)
{
    Console.WriteLine($"i = {i.Value}");
}
else
{
    Console.WriteLine("i não possui um valor");
}

Console.ReadKey(); 