// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Uso da Constatente ##\n");
//=============================== COMANDOS INTERESSANTES =======================================
double raio, perimetro, area;
const double PI = 3.14;
Console.Write("Informe aqui o raio do Circulo:");
raio = Convert.ToDouble(Console.ReadLine());

perimetro = 2*PI*raio;
area = PI*raio*raio;
Console.WriteLine($"Perimetro = {perimetro}");
Console.WriteLine($"area = {area}");


