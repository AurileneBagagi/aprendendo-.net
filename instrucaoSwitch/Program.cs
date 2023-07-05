Console.WriteLine("=============== Instrução Switch =================");
Console.WriteLine("Dias dos meses do ano");

int cargo = 0; 
int funcao = 0;
Console.WriteLine("Você é Gerente(1) ou Programador(2)");
cargo = Convert.ToInt32(Console.ReadLine());

if (cargo ==2)
{
    Console.WriteLine("Você é Junior(1) ou Senior(2)");
    funcao = Convert.ToInt32(Console.ReadLine());
}

switch (cargo)
{
    case 1:
        Console.WriteLine("\nBem vindo Gerente");
        break;
    case 2:
        Console.WriteLine("\nBem vindo Programador ");
        switch (funcao)
        {
                case 1:
                    Console.WriteLine("\nVocê é junior");
                    break;
                case 2:
                    Console.WriteLine("\nVocê é senior");
                    break;

        }
        break;
    default:
        Console.WriteLine("\nNão conseguimos te identificar");
        break;
}

Console.WriteLine("\nFim do processamento...");