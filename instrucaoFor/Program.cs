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