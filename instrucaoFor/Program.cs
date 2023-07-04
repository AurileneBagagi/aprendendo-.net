Console.WriteLine("=============== Instrução de Repetição For =================");

int resultado, numero, i;
Console.Write("Informe o número inteiro:");
numero = Convert.ToInt32(Console.ReadLine());

for (i = 0; i <= 10; i++) //caso queira incrementar +2 seria i+=2
{
    resultado = numero * i;
    Console.WriteLine($"{numero}*{i}={resultado}");
}

Console.WriteLine("\nFim do processamento...");

Console.WriteLine("=============== Instrução de Repetição For: multiplas expressões =================");


for (int x=0, y=0; x+y <= 20; x++,y++) //caso queira incrementar +2 seria i+=2
{
    Console.WriteLine($"x={x} e y={y}");
}

Console.WriteLine("\nFim do processamento...");
Console.WriteLine("=============== Instrução de Repetição For: seções opcionais =================");

int a=1;
for (; a <= 10; ) //caso queira incrementar +2 seria i+=2
{
    Console.WriteLine($"a={a}");
    a++;
}

Console.WriteLine("\nFim do processamento...");