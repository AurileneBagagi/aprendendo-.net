Console.WriteLine("## Divisão de números inteiros ##");
Console.WriteLine("  x / y ");

Console.WriteLine("\nInforme o valor de x ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nInforme o valor de y ");
int y = Convert.ToInt32(Console.ReadLine());

try
{
    int z = x / y;
    Console.WriteLine($"\n{x} / {y} = {z}");
}
catch (Exception exemplo) //exempro é uma variavel criada para informar o erro
{
    Console.WriteLine("\nNão existe divisão por zero, tente outro número...");

    Console.WriteLine($"\n Erro: <<< {exemplo.Message} >>>");
    Console.WriteLine($"\n Detalhes : {exemplo?.StackTrace?.ToString()}");
    //Operador condicional nulo: ex.:a?
    //1. Se a for avaliado como nulo, o resultado de a?.x será null;
    //2. Se a for avaliado como não nulo, o resultado de a?.x será igual ao resultado de a.x

}
finally
{
    Console.WriteLine("\nProcessamento concluído...");
}

Console.ReadKey();