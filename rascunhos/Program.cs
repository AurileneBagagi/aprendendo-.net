// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Operadores Aritméticos ##\n");
//=============================== COMANDOS INTERESSANTES =======================================
Console.WriteLine("Informe o valor de x");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe o valor de y");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"\n Raiz Quadrada de X = {Math.Sqrt(x)}");
Console.WriteLine($"\n Potencia de X elevado a Y = {Math.Pow(x,y)}");
Console.WriteLine($"\n Minimo entre X e Y = {Math.Min(x,y)}");
Console.WriteLine($"\n Máximo entre X e Y = {Math.Max(x,y)}");
Console.WriteLine($"\n Coseno de X = {Math.Cos(x)}");
Console.WriteLine($"\n Seno de X = {Math.Sin(x)}");
Console.WriteLine($"\n Exponencial de X = {Math.Exp(x)}");
