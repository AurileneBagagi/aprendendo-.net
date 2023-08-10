// ------------------------------------------

Console.WriteLine("Questão 3");
float[,] grupos = new float[2,5];

float grupo1=0.0f, grupo2 = 0.0f;

for (int i = 0; i < grupos.GetLength(0);i++)
{
    for (int j = 0; j < grupos.GetLength(1);j++)
    {
        Console.Write($"Informe o valor do {j}º ano do {i}º Grupo: ");
        grupos[i,j] = Convert.ToSingle(Console.ReadLine());
    }
}

for (int i = 0; i <5;i++)
{
    grupo1 += grupos[0,i];
}
Console.WriteLine($"\n A média aritimetica do primeiro grupo é {grupo1/5}");

for (int i = 0; i <5;i++)
{
    grupo2 += grupos[1,i];
}
Console.WriteLine($"\n A média aritimetica do segundo grupo é {grupo2/5}");
