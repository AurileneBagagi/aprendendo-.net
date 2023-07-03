// See https://aka.ms/new-console-template for more information
Console.WriteLine("=============== Instrução IF =================");
Console.WriteLine("Caso do cliente Especial");
Console.WriteLine("Modo 1 -------------");

Console.Write("Cliente especial (S/N):");
var client = Console.ReadLine();

if (client == "S")
{
    Console.WriteLine("Desconto de 10%");
}
Console.WriteLine("Fim do processamento\n");

Console.WriteLine("Modo 2 --------------");
Console.Write("Cliente especial (true/false):");
var cliente = Convert.ToBoolean(Console.ReadLine());
if (cliente)
{
    Console.WriteLine("Desconto de 20%");
}
Console.WriteLine("Fim do processamento");

Console.WriteLine("Modo 3 --------------");
Console.Write("Cliente especial (true/false):");
var cl = Convert.ToBoolean(Console.ReadLine());
if (cl)
    Console.WriteLine("Desconto de 20%");

Console.WriteLine("Fim do processamento");
