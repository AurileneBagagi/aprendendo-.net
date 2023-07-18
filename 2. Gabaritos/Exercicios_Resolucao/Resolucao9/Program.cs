using Resolucao9;

Forma c = new Circulo(3.5);
Console.WriteLine($"Área do círculo de raio 3.5. A = {c.Area()}");

Forma q = new Quadrado(5.5);
Console.WriteLine("Área do quadrado = {0}", q.Area());

Forma t = new Triangulo(3.0, 5.0);
Console.WriteLine("Área do triângulo = {0}", t.Area());

Console.ReadKey();

Console.WriteLine("\n ---------- Outra solução ------- \n");
var formas = new List<Forma>()
{
    new Circulo(3.5),
    new Quadrado(5.5),
    new Triangulo(3.0,5.0)
};

foreach(var forma in formas)
{
    Console.WriteLine(forma.Area());
}

Console.ReadKey();