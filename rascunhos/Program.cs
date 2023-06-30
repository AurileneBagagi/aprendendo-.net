// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Operadores Aritméticos ##\n");
//=============================== COMANDOS INTERESSANTES =======================================
Console.WriteLine("Informe o valor de x");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe o valor de y");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"\n Soma de x+y = {x+y}");
Console.WriteLine($"\n Subtração de x-y = {x-y}");
Console.WriteLine($"\n Multiplicação de x*y = {x*y}");
Console.WriteLine($"\n Divisão Inteira de x/y = {x/y}");
double divisaoderesto = (double) x/y;
Console.WriteLine($"\n Divisão de x/y = {divisaoderesto}");
Console.WriteLine($"\n Módulo da divisão de x%y = {x%y}");
