Console.WriteLine("=============== Instrução IF-Else-IF =================");
Console.WriteLine("Caso do Aluno aprovado ou reprovado");

Console.Write("Informe a nota do aluno: ");
var nota = Convert.ToDouble(Console.ReadLine());

if(nota < 5)
{
    Console.WriteLine("Aluno Reprovado");
}
else if (nota >= 5 && nota <6)
{
    Console.WriteLine("Aluno em Recuperação");
}
else if (nota >= 6 && nota <=9)
{
    Console.WriteLine("Aluno Aprovado");
}
else
{
    Console.WriteLine("Aluno Aprovado com distinção");
}
Console.WriteLine("Fim do processamento\n");

