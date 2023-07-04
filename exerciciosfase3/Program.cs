using System.Net;

Console.WriteLine(" ============== Execicios Fase 3: Estrutura de Controle ============");
/*
// ------------------------------------------
Console.WriteLine("\nQuestão 1");
int a,b,c;
Console.Write("Digite o primeiro numero: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite o segundo numero: ");
b = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite o terceiro numero: ");
c = Convert.ToInt32(Console.ReadLine());

if (a>b)
{
    if (a>c)
        Console.WriteLine($"O primeiro numero: {a} é o maior");
    else
        Console.WriteLine($"O terceiro numero: {c} é o maior");
}
else
{
    if (b>c)
        Console.WriteLine($"O segundo numero: {b} é o maior");
    else
        Console.WriteLine($"O terceiro numero: {c} é o maior");
}*/
// ------------------------------------------
Console.WriteLine("\nQuestão 2");
Console.WriteLine("Cálculo da equação do segundo grau (ax^2+bx+c)");
int a,b,c, delta, x1, x2;
Console.WriteLine("Informe o valor de A: ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe o valor de B: ");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe o valor de C: ");
c = Convert.ToInt32(Console.ReadLine());

delta =  (int) Math.Pow(b, 2) - 4*a*c;
x1 = (int) ((-b)+Math.Sqrt(delta))/2*a;
x2 = (int) ((-b)-Math.Sqrt(delta))/2*a;

if (delta>0)
{
    Console.WriteLine("Ambas as raízes são reais e diferentes");
    Console.WriteLine($"resultado de x1={((-b)+Math.Sqrt(delta))/2*a}");
    Console.WriteLine($"resultado de x2={((-b)-Math.Sqrt(delta))/2*a}");
}
else if (delta<0)
{
    Console.WriteLine("As raízes são imaginarias");
    Console.WriteLine("Sem solução para os números reais");
}
else
{
    Console.WriteLine("Ambas as raízes são reais e iguais");
    Console.WriteLine($"resultado de x1={((-b)+Math.Sqrt(delta))/2*a}");
    Console.WriteLine($"resultado de x2={((-b)-Math.Sqrt(delta))/2*a}");
}

