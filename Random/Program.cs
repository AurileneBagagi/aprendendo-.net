Random  aleatorios = new Random();
Console.WriteLine(aleatorios.Next());// numero alatorio de acordo com o intervalo padrão
Console.WriteLine(aleatorios.Next(20));// um numero aleatorio até o valor definido (20)
Console.WriteLine(aleatorios.Next(10,20));// numero alatorio entre o numero 10 e 20 (não inclui o 20)
Console.WriteLine(aleatorios.NextDouble());//numero alatorio do tipo double entre o intervalo de 0,0 a 1,0

Console.WriteLine("\nMais de um número ao mesmo tempo\n");
for (int i = 0;i<10;i++)
{
    Console.WriteLine(aleatorios.NextDouble());
}
Console.WriteLine("\nArrays do tipo Byte\n");

byte[] data = new byte[10];
Random  a = new Random(2023);
a.NextBytes(data); //preenche os elementos de um array de bytes com numeros aleatorios

for (int i = 0; i< data.Length ;i++)
{
    Console.Write($"{data[i]} ");
}

Console.WriteLine("\n\nSorteio da MegaSena\n");
int[] numero = new int[6];
for (int i=0;i<6;i++)
{
    int numeroAle;
    do
    {
        numeroAle = a.Next(1,61);
    }
    while (numero.Contains(numeroAle));
    numero[i]=numeroAle;
} 

Console.WriteLine(string.Join(" ", numero));

