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
else if (b>c)
    Console.WriteLine($"O segundo numero: {b} é o maior");
else
    Console.WriteLine($"O terceiro numero: {c} é o maior");

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
    Console.WriteLine($"resultado de x2={x1}");
}
// ------------------------------------------
Console.WriteLine("Questão 3");
Console.WriteLine("\nWhile ---------");
int n = 1, c = 0;
while (n<=10)
{
    Console.Write($"{n} ");
    c+=n;
    n++;
}
Console.WriteLine($"\nA soma dos números é: {c}");

Console.WriteLine("do-While ---------");
int i = 1, x = 0;
do 
{
    Console.Write($"{i} ");
    x+=i;
    i++;
}
while (i<=10);
Console.WriteLine($"\nA soma dos números é: {c}");
Console.WriteLine("For ---------");
int b=0;
for (int a=1;a<=10;a++)
{
    Console.Write($"{a} ");
    b+=a;
}
Console.WriteLine($"\nA soma dos números é: {b}"); 
// ------------------------------------------
Console.WriteLine("Questão 4");
while (true)
{
    Console.WriteLine("Informe um valor naior que zero\nDigite 0 para encerrar. ");
    int a = Convert.ToInt32(Console.ReadLine());
    if (a < 0)
        Console.WriteLine("Digite um número maior que zero!");
    else if (a == 0)
        break;
    else
    {
        Console.WriteLine($"### TABUADA DO {a}");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($" {a}*{i}={a*i}");
        }
        Console.WriteLine($"################");
    }
}
// ------------------------------------------
Console.WriteLine("Questão 5");
Console.WriteLine("Qual a instrução para sair de um loop?\na.Quit\nb.Continue\nc.Break\nd.Exit");
bool c = true;
while (c)
{
    Console.Write("Qual a opção Correta? (Digite x para sair)");
    var r = Convert.ToString(Console.ReadLine().ToLower());
    if (r=="c")
        Console.WriteLine("\nCerta resposta!");
    else if (r =="x")
    {
        Console.WriteLine("\nFim do processamento");
        c = false;
    }
    else
        Console.WriteLine("\nIncorreta resposta!");
}
// ------------------------------------------ 
Console.WriteLine("Questão 6");
Console.WriteLine("Incrementando 2 passos -----------");
for (int i = 10; i<=20;i+=2)
{
    if (i == 16)
        continue;
    Console.WriteLine(i);
}
Console.WriteLine("Incrementando com 1 passos -----------");
for (int x = 10; x<=20;x++)
{
    if (x%2 == 1 || x == 16 )
        continue;
    Console.WriteLine(x);
}
Console.WriteLine("Incrementando com loop infinito -----------");
int a = 10;
while (true)
{
    if (a>20)
        break;
    else if (a%2 == 1 || a == 16 )
    {   
        a++;
        continue;
    }
    Console.WriteLine(a);
    a++;
}
// ------------------------------------------ 
Console.WriteLine("Questão 7");
Console.WriteLine("Informe o numero de linhas: ");
int a = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i<=a; i++)
{
    for (int j=1; j<=i; j++)
        Console.Write("*");
    Console.WriteLine();
}
// ------------------------------------------
Console.WriteLine("Questão 8");
Console.Write("Informe o valor: ");
int a = Convert.ToInt32(Console.ReadLine());
int contador = 1;
for (int i=a; i > 0; i--)
    contador*=i;
Console.WriteLine($"\nfatorial de {a}! = {contador}");
// ------------------------------------------
Console.WriteLine("Questão 9");
int a =2;
do{
    Console.WriteLine($"##### Tabulada do {a} #######");
    int i = 0;
    do 
    {
        Console.WriteLine($"{a}*{i}={a*i}");
        i++;
    }
    while (i <=10);
    a++;
}
while (a <=6);
// ------------------------------------------ 
Console.WriteLine("Questão 10");
while (true)
{
    Console.Write("Digite a nota (Digite 11 para sair): ");
    int x = Convert.ToInt32(Console.ReadLine());
    if (x == 11)
        break;
    switch (x)
    {
        case 10:
            Console.WriteLine("Avaliação: A+");
            break;
        case 9:
            Console.WriteLine("Avaliação: A");
            break;
        case 7:
        case 8:
            Console.WriteLine("Avaliação: B");
            break;
        case 6:
            Console.WriteLine("Avaliação: C");
            break;
        case 5:
            Console.WriteLine("Avaliação: E");
            break;
        default:
            Console.WriteLine("Avaliação: F");
            break;
    }
}
// ------------------------------------------ */
Console.WriteLine("Questão 11");
Console.WriteLine("Informe o valor de A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe o operador(+,-,/,*): ");
var b = Console.ReadLine();
Console.WriteLine("Informe o valor de C: ");
int c = Convert.ToInt32(Console.ReadLine());
float r;
switch (b)
{
    case "+":
        r=a+c;
        break;
    case "-":
        r=a-c;
        break;
    case "/":
        r= (float) a/c;
        break;
    case "*":
        r=a*c;
        break;
    default:
        r=0;
        break;
}
Console.WriteLine($"{a}{b}{c}={r}");