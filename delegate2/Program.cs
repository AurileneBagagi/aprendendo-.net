Console.WriteLine("Questão 2 do Exercicio de Delegate, Labda e LINQ");

// Console.WriteLine("Digite o numero x");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Digite o numero y");
// int y = Convert.ToInt32(Console.ReadLine());

OperacaoMatematica delSoma = Soma;
//delSoma+=Sub;
int resultado = delSoma(66,44);
Console.WriteLine($"Resultado da Soma 66+44 = {resultado}");

static int Soma(int x, int y)
{
    Console.WriteLine("Soma");
    return x+y;
}
/*
static int Sub(int x, int y)
{
    Console.WriteLine("Sub");
    return x-y;
}*/
public delegate int OperacaoMatematica(int x, int y);
