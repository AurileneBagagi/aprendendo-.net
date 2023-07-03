Console.WriteLine("=============== Instrução IF-Else =================");
Console.WriteLine("Caso do Aluno aprovado ou reprovado");

Console.Write("Informe a nota do aluno \t");
var client = Convert.ToInt32(Console.ReadLine());

if (client > 5)
{
    Console.WriteLine("Aluno Aprovado");
}
else
{
    Console.WriteLine("Aluno Reprovado");
}
Console.WriteLine("Fim do processamento\n");

Console.WriteLine("Caso do If-Else Aninhado");

Console.Write("Informe o valor de x: \t");
var x = Convert.ToInt32(Console.ReadLine());
Console.Write("Informe o valor de y: \t");
var y = Convert.ToInt32(Console.ReadLine());
if (x>y)
{
    Console.WriteLine("X é maior que y");
}
else
{
    if (x<y)
    {
        Console.WriteLine("X é menor que y");
    }
    else
    {
        Console.WriteLine("X é igual a y");
    }
}
Console.WriteLine("Fim do processamento\n");
