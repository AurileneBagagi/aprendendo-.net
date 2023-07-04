Console.WriteLine("=============== Instrução Switch =================");
Console.WriteLine("Numero de parcelas");

int compra = 600;
Console.WriteLine($"Valor da compra R${compra}");
Console.Write("Informe o numero de parcelas (1 a 3): ");
var nParcelas = Convert.ToInt32(Console.ReadLine());

switch (nParcelas)
{
    case 1:
        Console.WriteLine($"\nPrestação R${compra/nParcelas}");
        break;
    case 2:
        Console.WriteLine($"\nPrestação R${compra/nParcelas}");
        break;
    case 3:
        Console.WriteLine($"\nPrestação R${compra/nParcelas}");
        break;
    default:
        Console.WriteLine("Valor invalido, informe 1, 2, ou 3");
        break;
}

Console.WriteLine("Impar ou Par");

Console.Write("Informe o numero: ");
var numero = Convert.ToInt32(Console.ReadLine());

switch (numero%2)
{
    case 0:
        Console.WriteLine($"\n {numero} é par");
        break;
    default:
        Console.WriteLine($"\n {numero} é impar");
        break;
}