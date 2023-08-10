using Heranca6;
Console.WriteLine(" ---- Exercicio6(10) ----");
//Polimorfismo

Formas quadrado = new Quadrado(5.5);
Console.WriteLine($" Area do Quadrado {quadrado.Area()}");
Formas triangulo = new Triangulo(3.0,5.0);
Console.WriteLine($" Area do Triango {triangulo.Area()}");
Formas circulo = new Circulo(3.5);
Console.WriteLine($" Area do Circulo {circulo.Area()}");




