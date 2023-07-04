Console.WriteLine("=============== Instrução Switch =================");
Console.WriteLine("Dias dos meses do ano");

Console.Write("Informe o nome do mês: ");
var mes = Console.ReadLine().ToLower();

switch (mes)
{
    case "janeiro":
    case "março":
    case "maio":
    case "julho":
    case "agosto":
    case "outubro":
    case "dezembro":
        Console.WriteLine("Este mês tem 31 dias");
        break;
    case "fevereiro":
        Console.WriteLine("Este mês tem 28 ou 29 dias");
        break;
    default:
        Console.WriteLine("Este mês tem 30 dias");
        break;      
}
Console.WriteLine("\nFim do processamento...");